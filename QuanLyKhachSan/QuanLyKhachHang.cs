using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyKhachSan
{
    
    public partial class QuanLyKhachHang: Form
    {
        connectDB db = new connectDB();  // Sử dụng đối tượng kết nối
        //SqlConnection con = db.GetConnection();  // Lấy kết nối từ class connectDB
        SqlDataAdapter adt;
        SqlCommand cmd;
        DataTable dt;

        private string selectedValue;
        public QuanLyKhachHang()
        {
            InitializeComponent();
            Load_Data();
            adt = new SqlDataAdapter();
            dt = new DataTable();
        }

        private void Load_Data()
        {

            // Đảm bảo kết nối được mở
            SqlConnection con = connectDB.GetConnection();  // Sử dụng phương thức GetConnection từ class connectDB
            if (con.State == ConnectionState.Closed)
                con.Open();

            // Câu lệnh SQL để lấy dữ liệu khách hàng
            string sqlkh = @"SELECT
         kh.KHACHHANGID AS 'Mã khách hàng',
         kh.HOTEN AS 'Họ tên',
         kh.GIOITINH AS 'Giới tính',
         kh.NGAYSINH AS 'Ngày sinh',
         kh.SODIENTHOAI AS 'Số điện thoại',
         kh.DIACHI AS 'Địa chỉ',
         kh.EMAIL AS 'Email',
         COALESCE(CAST(dp.NGAYDAT AS DATE), '1900-01-01') AS 'Ngày đặt phòng',  -- Thay thế NULL bằng ngày mặc định hợp lệ
         SUM(ISNULL(hd.TIENPHONG, 0) + ISNULL(hd.TIENDICHVU, 0)) AS 'Tổng chi tiêu',  -- Tổng chi tiêu, nếu không có hóa đơn, trả về 0
         kh.GHICHU AS 'Loại khách hàng'
    FROM
         KhachHang kh
     LEFT JOIN
         DatPhong dp ON kh.KHACHHANGID = dp.KHACHHANGID
     LEFT JOIN
         HoaDonTongHop hd ON dp.DATPHONGID = hd.DATPHONGID
     LEFT JOIN
         DatDichVu ddv ON dp.DATPHONGID = ddv.DATPHONGID
     GROUP BY
         kh.KHACHHANGID, kh.HOTEN, kh.GIOITINH, kh.NGAYSINH, kh.SODIENTHOAI, kh.DIACHI, kh.EMAIL, kh.GHICHU, dp.NGAYDAT
     ORDER BY
         kh.KHACHHANGID;";

            try
            {
                cmd = new SqlCommand(sqlkh, con);

                adt = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adt.Fill(dt);
                grvkh.DataSource = dt;

                grvkh.Columns["Mã khách hàng"].Width = 50;  // Sử dụng tên cột chính xác
                grvkh.Columns["Họ tên"].Width = 100;
                grvkh.Columns["Giới tính"].Width = 50;
                grvkh.Columns["Ngày sinh"].Width = 100;
                grvkh.Columns["Số điện thoại"].Width = 100;
                grvkh.Columns["Địa chỉ"].Width = 150;
                grvkh.Columns["Email"].Width = 150;
                grvkh.Columns["Ngày đặt phòng"].Width = 100;
                grvkh.Columns["Tổng chi tiêu"].Width = 100;
                grvkh.Columns["Loại khách hàng"].Width = 120;

                // Đóng kết nối sau khi thực hiện xong
                con.Close();
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi nếu có vấn đề
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void QuanLyKhachHang_Load(object sender, EventArgs e)
        {
            // Cài đặt văn bản placeholder mặc định
         
        }

        private void textBox1_Paint(object sender, PaintEventArgs e)
        {
            // Hiển thị placeholder nếu TextBox chưa có dữ liệu và không đang có focus
            if (string.IsNullOrEmpty(searchName.Text) && !searchName.Focused)
            {
                using (Brush brush = new SolidBrush(Color.Gray))
                {
                    e.Graphics.DrawString(searchName.Text, searchName.Font, brush, new PointF(5, 5));
                }
            }
            if (string.IsNullOrEmpty(searchMKH.Text) && !searchMKH.Focused)
            {
                using (Brush brush = new SolidBrush(Color.Gray))
                {
                    e.Graphics.DrawString(searchMKH.Text, searchMKH.Font, brush, new PointF(5, 5));
                }
            }
            if (string.IsNullOrEmpty(searchPhoneNumber.Text) && !searchPhoneNumber.Focused)
            {
                using (Brush brush = new SolidBrush(Color.Gray))
                {
                    e.Graphics.DrawString(searchPhoneNumber.Text, searchPhoneNumber.Font, brush, new PointF(5, 5));
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Xử lý sự kiện cho button nếu cần
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Xử lý sự kiện cho label nếu cần
        }

        private void QuanLyKhachHang_Load_1(object sender, EventArgs e)
        {
            searchName.Text = "Tên khách hàng...";
            searchName.ForeColor = Color.Gray;  // Màu xám cho placeholder
            searchMKH.Text = "Nhập mã khách hàng...";
            searchMKH.ForeColor = Color.Gray;  // Màu xám cho placeholder
            searchPhoneNumber.Text = "Nhập số điện thoại...";
            searchPhoneNumber.ForeColor = Color.Gray;
        }

        private void searchName_Enter(object sender, EventArgs e)
        {
            if (searchName.Text == "Tên khách hàng...")
            {
                searchName.Text = "";
                searchName.ForeColor = Color.Black;  // Màu chữ đen khi bắt đầu nhập
            }
        }

        private void searchName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(searchName.Text))
            {
                searchName.Text = "Tên khách hàng...";
                searchName.ForeColor = Color.Gray;  // Màu xám cho placeholder
            }
        }

        private void searchMKH_Enter(object sender, EventArgs e)
        {
            if (searchMKH.Text == "Nhập mã khách hàng...")
            {
                searchMKH.Text = "";
                searchMKH.ForeColor = Color.Black;  // Màu chữ đen khi bắt đầu nhập
            }
        }

        private void searchMKH_Leave(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(searchMKH.Text))
            {
                searchMKH.Text = "Nhập mã khách hàng...";
                searchMKH.ForeColor = Color.Gray;  // Màu xám cho placeholder
            }
        }

        private void searchPhoneNumber_Enter(object sender, EventArgs e)
        {
            if (searchPhoneNumber.Text == "Nhập số điện thoại...")
            {
                searchPhoneNumber.Text = "";
                searchPhoneNumber.ForeColor = Color.Black;  // Màu chữ đen khi bắt đầu nhập
            }
        }

        private void searchPhoneNumber_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(searchPhoneNumber.Text))
            {
                searchPhoneNumber.Text = "Nhập số điện thoại...";
                searchPhoneNumber.ForeColor = Color.Gray;  // Màu xám cho placeholder
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void menu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void grvkh_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (grvkh.Columns[e.ColumnIndex].Name == "Ngày đặt phòng")
            {
                // Kiểm tra nếu giá trị là NULL
                if (e.Value == DBNull.Value)
                {
                    e.Value = "Đang xử lý";  // Hiển thị "Đang xử lý" nếu là NULL
                }
                else if (e.Value is DateTime)
                {
                    // Kiểm tra nếu giá trị là ngày 1900-01-01
                    DateTime dateValue = (DateTime)e.Value;
                    if (dateValue == new DateTime(1900, 1, 1))
                    {
                        e.Value = "Đang xử lý";  // Hiển thị "Đang xử lý" nếu ngày là 1900-01-01
                    }
                }
            }
            if (grvkh.Columns[e.ColumnIndex].Name == "Tổng chi tiêu")
            {
                    // Kiểm tra nếu tổng chi tiêu bằng 0
                    decimal totalAmount = Convert.ToDecimal(e.Value);
                    if (totalAmount == 0)
                    {
                        e.Value = "Chưa thanh toán";  // Hiển thị "Chưa thanh toán" nếu tổng chi tiêu là 0
                    }
            }
        }

        private void addnew_Click(object sender, EventArgs e)
        {
            DialogThemKhachHang dialog = new DialogThemKhachHang();
            dialog.ShowDialog();
        }

        internal void LoadData()
        {
            throw new NotImplementedException();
        }
    }
}