using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Globalization;
using System.Runtime.InteropServices;
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
                sql += " AND hd.TINHTRANGTHANHTOAN = 'Chưa thanh toán'";
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

        private void button3_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbooks oBooks;
            Microsoft.Office.Interop.Excel.Sheets oSheets;
            Microsoft.Office.Interop.Excel.Workbook oBook;
            Microsoft.Office.Interop.Excel.Worksheet oSheet;

            // Tạo mới một Excel WorkBook
            oExcel.Visible = true;
            oExcel.DisplayAlerts = false;
            oExcel.Application.SheetsInNewWorkbook = 1;
            oBooks = oExcel.Workbooks;
            oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));
            oSheets = oBook.Worksheets;
            oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);
            oSheet.Name = "Danh sách khách hàng";

            // Tạo phần đầu của Excel sheet
            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "I1");
            head.MergeCells = true;
            head.Value2 = "DANH SÁCH KHÁCH HÀNG";
            head.Font.Bold = true;
            head.Font.Name = "Tahoma";
            head.Font.Size = 18;
            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tạo tiêu đề cột
            // Thiết lập tên cột và độ rộng cho các cột trong Excel
            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");
            cl1.Value2 = "Mã khách hàng";
            cl1.ColumnWidth = 12.0;

            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");
            cl2.Value2 = "Họ tên";
            cl2.ColumnWidth = 25.0;

            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");
            cl3.Value2 = "Giới tính";
            cl3.ColumnWidth = 12.0;

            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");
            cl4.Value2 = "Ngày sinh";
            cl4.ColumnWidth = 15.0;

            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");
            cl5.Value2 = "Số điện thoại";
            cl5.ColumnWidth = 20.0;

            Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");
            cl6.Value2 = "Địa chỉ";
            cl6.ColumnWidth = 25.0;

            Microsoft.Office.Interop.Excel.Range cl7 = oSheet.get_Range("G3", "G3");
            cl7.Value2 = "Số CCCD"; // Cột Số CCCD
            cl7.ColumnWidth = 20.0;

            Microsoft.Office.Interop.Excel.Range cl8 = oSheet.get_Range("H3", "H3");
            cl8.Value2 = "Email"; // Cột Email
            cl8.ColumnWidth = 25.0;

            Microsoft.Office.Interop.Excel.Range cl9 = oSheet.get_Range("I3", "I3");
            cl9.Value2 = "Ngày đặt phòng"; // Cột Ngày đặt phòng
            cl9.ColumnWidth = 15.0;

            Microsoft.Office.Interop.Excel.Range cl10 = oSheet.get_Range("J3", "J3");
            cl10.Value2 = "Tổng chi tiêu"; // Cột Tổng chi tiêu
            cl10.ColumnWidth = 18.0;

            Microsoft.Office.Interop.Excel.Range cl11 = oSheet.get_Range("K3", "K3");
            cl11.Value2 = "Loại khách"; // Cột Loại khách
            cl11.ColumnWidth = 15.0;



            // Định dạng dòng tiêu đề
            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "K3");
            rowHead.Font.Bold = true;
            rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
            rowHead.Interior.ColorIndex = 15;
            rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tạo mảng đối tượng để lưu dữ liệu từ DataGridView
            object[,] arr = new object[grvkh.Rows.Count, grvkh.Columns.Count];

            // Chuyển dữ liệu từ DataGridView vào mảng đối tượng
            for (int r = 0; r < grvkh.Rows.Count; r++)
            {
                DataGridViewRow dr = grvkh.Rows[r];
                for (int c = 0; c < grvkh.Columns.Count; c++)
                {
                    // Kiểm tra cột "Ngày sinh"
                    if (grvkh.Columns[c].Name == "Ngày sinh" || grvkh.Columns[c].Name == "Ngày đặt phòng")
                    {
                        if (dr.Cells[c].Value != null && DateTime.TryParse(dr.Cells[c].Value.ToString(), out DateTime birthDate))
                        {
                            arr[r, c] = birthDate.ToString("dd/MM/yyyy"); // Định dạng ngày sinh
                        }
                        else
                        {
                            arr[r, c] = "";  // Nếu không hợp lệ, để trống
                        }
                    }
                    // Kiểm tra các cột "Số điện thoại" và "Số CCCD"
                    else if (grvkh.Columns[c].Name == "Số điện thoại" || grvkh.Columns[c].Name == "Số CCCD")
                    {
                        if (dr.Cells[c].Value != null)
                        {
                            // Đảm bảo dữ liệu không bị mất số 0, dùng dấu nháy đơn để Excel nhận là chuỗi
                            arr[r, c] = "'" + dr.Cells[c].Value.ToString();
                        }
                        else
                        {
                            arr[r, c] = "";  // Nếu không có giá trị, để trống
                        }
                    }
                    else
                    {
                        // Lưu các cột khác
                        arr[r, c] = dr.Cells[c].Value ?? ""; // Nếu giá trị ô là null, trả về chuỗi rỗng
                    }
                }
            }

            // Thiết lập vùng để điền dữ liệu vào Excel
            int rowStart = 4;
            int columnStart = 1;
            int rowEnd = rowStart + grvkh.Rows.Count - 1;
            int columnEnd = grvkh.Columns.Count;

            // Lấy vùng cần điền dữ liệu
            Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnStart];
            Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];
            Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c1, c2);

            // Điền dữ liệu vào vùng Excel đã chọn
            range.Value2 = arr;

            // Kẻ viền cho các ô đã điền dữ liệu
            range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            // Căn giữa cột dữ liệu
            Microsoft.Office.Interop.Excel.Range c3 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnStart];
            Microsoft.Office.Interop.Excel.Range c4 = oSheet.get_Range(c1, c3);
            oSheet.get_Range(c3, c4).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
    }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Files|*.xls;*.xlsx";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                ImportExcel(filePath);
                InsertDataIntoDatabase();
            }

        }

        // Đọc dữ liệu từ Excel và chuyển vào DataTable
        public void ImportExcel(string filePath)
        {
            // Khởi tạo ứng dụng Excel
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook workbook = excelApp.Workbooks.Open(filePath);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = workbook.Sheets[1]; // Lấy sheet đầu tiên
            Microsoft.Office.Interop.Excel.Range range = worksheet.UsedRange; // Lấy phạm vi đã sử dụng

            // Tạo một DataTable để lưu dữ liệu
            DataTable dt = new DataTable();

            // Lấy tên cột từ hàng đầu tiên của sheet
            for (int col = 1; col <= range.Columns.Count; col++)
            {
                string columnName = range.Cells[1, col].Value2?.ToString();
                if (!string.IsNullOrEmpty(columnName))  // Kiểm tra tên cột không rỗng
                {
                    dt.Columns.Add(columnName);
                }
            }

            // Lấy dữ liệu từ các hàng còn lại
            for (int row = 2; row <= range.Rows.Count; row++)  // Bắt đầu từ dòng thứ 2 vì dòng 1 là tiêu đề cột
            {
                DataRow newRow = dt.NewRow();
                for (int col = 1; col <= range.Columns.Count; col++)
                {
                    string cellValue = range.Cells[row, col].Value2?.ToString();
                    string columnName = dt.Columns[col - 1].ColumnName;

                    // Kiểm tra và xử lý cột "Ngày sinh" để chuyển đổi định dạng ngày hợp lệ
                    if (columnName == "Ngày sinh" && !string.IsNullOrEmpty(cellValue))
                    {
                        try
                        {
                            DateTime ngaySinh;

                            // Kiểm tra nếu giá trị là một số (serial number của Excel)
                            if (double.TryParse(cellValue, out double serialDate))
                            {
                                ngaySinh = DateTime.FromOADate(serialDate); // Chuyển số serial thành DateTime
                            }
                            else
                            {
                                ngaySinh = DateTime.ParseExact(cellValue, "yyyy/MM/dd", CultureInfo.InvariantCulture);
                            }

                            // Chuyển đổi thành chuỗi theo định dạng yyyy-MM-dd
                            newRow[col - 1] = ngaySinh.ToString("yyyy-MM-dd");
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show($"Ngày sinh '{cellValue}' không hợp lệ tại dòng {row}.", "Lỗi định dạng ngày sinh", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            newRow[col - 1] = DBNull.Value; // Nếu không hợp lệ, đặt giá trị trống (DBNull)
                        }
                    }
                    else
                    {
                        // Kiểm tra nếu giá trị là null hoặc rỗng
                        if (string.IsNullOrEmpty(cellValue))
                        {
                            newRow[col - 1] = DBNull.Value; // Nếu ô trống, gán DBNull.Value
                        }
                        else
                        {
                            newRow[col - 1] = cellValue; // Nếu có giá trị, gán giá trị ô vào DataRow
                        }
                    }
                }

                dt.Rows.Add(newRow);  // Thêm dòng vào DataTable
            }

            // Đóng Excel sau khi xử lý xong
            workbook.Close(false);
            excelApp.Quit();

            // Giải phóng tài nguyên Excel
            Marshal.ReleaseComObject(range);
            Marshal.ReleaseComObject(worksheet);
            Marshal.ReleaseComObject(workbook);
            Marshal.ReleaseComObject(excelApp);

            // Gán DataTable vào DataGridView
            grvkh.DataSource = dt;
        }

        // Chèn dữ liệu từ DataTable vào cơ sở dữ liệu
        public void InsertDataIntoDatabase()
        {
            // Kết nối với cơ sở dữ liệu
            SqlConnection con = connectDB.GetConnection();
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                // Chuẩn bị câu lệnh INSERT
                string insertQuery = @"INSERT INTO KhachHang (HOTEN, GIOITINH, NGAYSINH, SODIENTHOAI, DIACHI, SOCCCD, EMAIL, GHICHU) 
                               VALUES (@HOTEN, @GIOITINH, @NGAYSINH, @SODIENTHOAI, @DIACHI, @SOCCCD, @EMAIL, @GHICHU)";

                // Duyệt qua từng dòng trong DataGridView và thêm vào cơ sở dữ liệu
                foreach (DataGridViewRow row in grvkh.Rows)
                {
                    // Bỏ qua hàng trống
                    if (row.IsNewRow) continue;

                    // Tạo đối tượng SqlCommand
                    SqlCommand cmd = new SqlCommand(insertQuery, con);

                    // Kiểm tra và chuyển đổi ngày tháng
                    DateTime birthDate;
                    object birthDateValue = row.Cells["Ngày sinh"].Value;
                   
                    if (birthDateValue != null && DateTime.TryParse(birthDateValue.ToString(), out birthDate))
                    {
                        cmd.Parameters.AddWithValue("@NGAYSINH", birthDate);
                    }
                    else
                    {
                        // Nếu ngày sinh không hợp lệ (trống hoặc không thể chuyển đổi), gán giá trị mặc định
                        cmd.Parameters.AddWithValue("@NGAYSINH", new DateTime(1900, 1, 1));
                    }
                    // Thêm các tham số khác từ DataGridView vào câu lệnh INSERT
                    cmd.Parameters.AddWithValue("@HOTEN", row.Cells["Họ tên"].Value ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@GIOITINH", row.Cells["Giới tính"].Value ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@SODIENTHOAI", row.Cells["Số điện thoại"].Value ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@DIACHI", row.Cells["Địa chỉ"].Value ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@SOCCCD", row.Cells["Số CCCD"].Value ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@EMAIL", row.Cells["Email"].Value ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@GHICHU", row.Cells["Loại khách hàng"].Value ?? DBNull.Value);

                    // Thực thi câu lệnh
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Dữ liệu đã được nhập vào cơ sở dữ liệu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi nhập dữ liệu vào DB: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close(); // Đảm bảo đóng kết nối
            }
        }


    }
}