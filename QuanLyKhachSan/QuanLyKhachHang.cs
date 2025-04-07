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
            dateTimeSearch.Value = new DateTime(1900, 1, 1);

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
         kh.SOCCCD AS 'Số CCCD',
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
         kh.KHACHHANGID, kh.SOCCCD, kh.HOTEN, kh.GIOITINH, kh.NGAYSINH, kh.SODIENTHOAI, kh.DIACHI, kh.EMAIL, kh.GHICHU, dp.NGAYDAT
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
                grvkh.Columns["Giới tính"].Width = 40;
                grvkh.Columns["Ngày sinh"].Width = 90;
                grvkh.Columns["Số điện thoại"].Width = 90;
                grvkh.Columns["Số CCCD"].Width = 90;
                grvkh.Columns["Địa chỉ"].Width = 140;
                grvkh.Columns["Email"].Width = 140;
                grvkh.Columns["Ngày đặt phòng"].Width = 90;
                grvkh.Columns["Tổng chi tiêu"].Width = 90;
                grvkh.Columns["Loại khách hàng"].Width = 110;

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
            searchName.ForeColor = Color.Gray;  // Màu xám cho placeholder searchPhoneNumber.Text = "Nhập số điện thoại...";
            searchPhoneNumber.ForeColor = Color.Gray;
            searchPhoneNumber.Text = "Nhập số điện thoại...";
            searchName.ForeColor = Color.Gray;  // Màu xám cho placeholder searchPhoneNumber.Text = "Nhập số điện thoại...";
            searchPhoneNumber.ForeColor = Color.Gray;
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
                // Kiểm tra nếu giá trị là NULL
                if (e.Value == DBNull.Value)
                {
                    e.Value = "Chưa thanh toán";  // Hiển thị "Chưa thanh toán" nếu là NULL
                }
                else
                {
                    // Kiểm tra nếu tổng chi tiêu bằng 0
                    decimal totalAmount = Convert.ToDecimal(e.Value);
                    if (totalAmount == 0)
                    {
                        e.Value = "Chưa thanh toán";  // Hiển thị "Chưa thanh toán" nếu tổng chi tiêu là 0
                    }
                }
            }
        }

        private void addnew_Click(object sender, EventArgs e)
        {
            DialogThemKhachHang dialog = new DialogThemKhachHang();
            dialog.ShowDialog();
            Load_Data();
        }
        

        private void grvkh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = grvkh.Rows[e.RowIndex];

                // Nếu đó là hàng trống
                if (row.IsNewRow)
                {
                    MessageBox.Show("Không thể thao tác với hàng trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Dừng lại không làm gì với hàng trống
                }

          

                // Tiến hành các thao tác khác sau khi kiểm tra
            }
        }

        private void searchName_Enter_1(object sender, EventArgs e)
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



        private void searchPhoneNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchPhoneNumber_Enter_1(object sender, EventArgs e)
        {
            if (searchPhoneNumber.Text == "Nhập số điện thoại...")
            {
                searchPhoneNumber.Text = "";
                searchPhoneNumber.ForeColor = Color.Black;  // Màu chữ đen khi bắt đầu nhập
            }
        }

        private void searchPhoneNumber_Leave_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(searchPhoneNumber.Text))
            {
                searchPhoneNumber.Text = "Nhập số điện thoại...";
                searchPhoneNumber.ForeColor = Color.Gray;  // Màu xám cho placeholder
            }
        }

        private void search_Click(object sender, EventArgs e)
        {
            string customerName = searchName.Text.Trim();  // Tên khách hàng
            string phoneNumber = searchPhoneNumber.Text.Trim();    // Số điện thoại
            DateTime? bookingDate = dateTimeSearch.Value;       // Ngày đặt phòng
            string formattedDate = bookingDate.Value.ToString("yyyy-MM-dd");
            bool isPaid = checkBoxSearch.Checked;
            string sql = @"SELECT
                 kh.KHACHHANGID AS 'Mã khách hàng',
                 kh.HOTEN AS 'Họ tên',
                 kh.GIOITINH AS 'Giới tính',
                 kh.NGAYSINH AS 'Ngày sinh',
                 kh.SODIENTHOAI AS 'Số điện thoại',
                 kh.DIACHI AS 'Địa chỉ',
                 kh.SOCCCD AS 'Số CCCD',
                 kh.EMAIL AS 'Email',
                 COALESCE(CAST(dp.NGAYDAT AS DATE), '1900-01-01') AS 'Ngày đặt phòng',  --Thay thế NULL bằng ngày mặc định hợp lệ
                 SUM(ISNULL(hd.TIENPHONG, 0) + ISNULL(hd.TIENDICHVU, 0)) AS 'Tổng chi tiêu',  --Tổng chi tiêu, nếu không có hóa đơn, trả về 0
                 kh.GHICHU AS 'Loại khách hàng'
            FROM
                 KhachHang kh
             LEFT JOIN
                 DatPhong dp ON kh.KHACHHANGID = dp.KHACHHANGID
             LEFT JOIN
                 HoaDonTongHop hd ON dp.DATPHONGID = hd.DATPHONGID
             LEFT JOIN
                 DatDichVu ddv ON dp.DATPHONGID = ddv.DATPHONGID 
             WHERE 1=1 ";
            // Kiểm tra nếu tên khách hàng hợp lệ
            if (!string.IsNullOrEmpty(customerName) && customerName != "Tên khách hàng...")
            {
                sql += " AND kh.HOTEN LIKE @HOTEN";
            }

            // Kiểm tra nếu số điện thoại hợp lệ
            if (!string.IsNullOrEmpty(phoneNumber) && phoneNumber != "Nhập số điện thoại...")
            {
                sql += " AND kh.SODIENTHOAI LIKE @SODIENTHOAI";
            }
          
            // Kiểm tra nếu có ngày đặt phòng
            if (bookingDate != null && bookingDate != new DateTime(1900, 1, 1))
            {
                sql += " AND dp.NGAYDAT = '"+formattedDate+"'";
            }
            // Kiểm tra nếu tình trạng thanh toán được chọn
            if (isPaid)
            {
                sql += " AND hd.TINHTRANGTHANHTOAN = 'Đã thanh toán'";
            }
            sql += @" GROUP BY
                     kh.KHACHHANGID,kh.SOCCCD, kh.HOTEN, kh.GIOITINH, kh.NGAYSINH, kh.SODIENTHOAI, kh.DIACHI, kh.EMAIL, kh.GHICHU, dp.NGAYDAT
                        ORDER BY
                     kh.KHACHHANGID;";
            //MessageBox.Show(sql);

            // Tạo kết nối với cơ sở dữ liệu và thực thi câu lệnh
            SqlConnection con = connectDB.GetConnection();
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                SqlCommand cmd = new SqlCommand(sql, con);

                // Thêm các tham số vào câu truy vấn
                if (!string.IsNullOrEmpty(customerName))
                {
                    cmd.Parameters.AddWithValue("@HOTEN",'%'+customerName+'%');
                }
                if (!string.IsNullOrEmpty(phoneNumber))
                {
                    cmd.Parameters.AddWithValue("@SODIENTHOAI",'%'+ phoneNumber+'%');
                }

                //if (bookingDate != null)
                //{
                //    string formattedDate = bookingDate.Value.ToString("yyyy-MM-dd");
                //    cmd.Parameters.AddWithValue("@NGAYDAT", formattedDate);
                //}

                // Nếu tình trạng thanh toán được chọn
                if (isPaid)
                {
                    cmd.Parameters.AddWithValue("@TINHTRANG", "Đã thanh toán");
                }



                // Thực thi câu lệnh và lấy kết quả
                SqlDataAdapter adt = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adt.Fill(dt);

                // Hiển thị kết quả trong DataGridView
                grvkh.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            if (grvkh.SelectedRows.Count > 0)
            {
                // Lấy dữ liệu từ hàng được chọn
                DataGridViewRow row = grvkh.SelectedRows[0];  // Chọn dòng đầu tiên trong hàng đã chọn

                // Lấy thông tin từ các cột trong hàng
                int customerId = Convert.ToInt32(row.Cells["Mã khách hàng"].Value);
                string customerName = row.Cells["Họ tên"].Value.ToString();
                string gender = row.Cells["Giới tính"].Value.ToString();
                string cccd = row.Cells["Số CCCD"].Value.ToString();
                string phoneNumber = row.Cells["Số điện thoại"].Value.ToString();
                string address = row.Cells["Địa chỉ"].Value.ToString();
                string email = row.Cells["Email"].Value.ToString();
                string note = row.Cells["Loại khách hàng"].Value.ToString();
                DateTime birthDate = Convert.ToDateTime(row.Cells["Ngày sinh"].Value);  // Chuyển đổi ngày

                // Mở form DialogEditKhachHang và truyền dữ liệu vào
                DialogEditKhachHang dialog = new DialogEditKhachHang();
                dialog.CustomerId = customerId;
                dialog.CustomerName = customerName;
                dialog.CCCD = cccd;
                dialog.Gender = gender;
                dialog.PhoneNumber = phoneNumber;
                dialog.Address = address;
                dialog.Email = email;
                dialog.Note = note;
                dialog.BirthDate = birthDate;

                // Hiển thị form DialogEditKhachHang
                dialog.ShowDialog();
                Load_Data();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một khách hàng để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng này chưa được triển khai.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu có dòng nào trong DataGridView được chọn
            if (grvkh.SelectedRows.Count > 0)
            {
                // Lấy ID khách hàng từ hàng đã chọn
                int customerId = Convert.ToInt32(grvkh.SelectedRows[0].Cells["Mã khách hàng"].Value);

                // Xác nhận xóa khách hàng
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    // Tạo kết nối đến cơ sở dữ liệu
                    SqlConnection con = connectDB.GetConnection();
                    try
                    {
                        if (con.State == ConnectionState.Closed)
                            con.Open();

                        // Câu lệnh SQL để xóa khách hàng
                        string sqlDelete = "DELETE FROM KhachHang WHERE KHACHHANGID = @KHACHHANGID";

                        // Tạo SqlCommand và thêm tham số
                        SqlCommand cmd = new SqlCommand(sqlDelete, con);
                        cmd.Parameters.AddWithValue("@KHACHHANGID", customerId);

                        // Thực thi câu lệnh xóa
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // Thông báo xóa thành công
                            MessageBox.Show("Khách hàng đã được xóa thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Cập nhật lại dữ liệu trong DataGridView sau khi xóa
                            Load_Data(); // Gọi lại hàm LoadData để reload data vào DataGridView
                        }
                        else
                        {
                            // Nếu không có hàng nào bị xóa
                            MessageBox.Show("Khách hàng không tồn tại hoặc đã bị xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        // Hiển thị lỗi nếu có
                        MessageBox.Show("Lỗi khi xóa khách hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        con.Close(); // Đảm bảo đóng kết nối
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khách hàng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}