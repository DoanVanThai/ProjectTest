using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class DialogThemKhachHang : Form
    {
        public DialogThemKhachHang()
        {
            
            InitializeComponent();
            typekhAdd.SelectedIndex = 0; // Chọn mặc định là --Chọn--
            cbbgt.Items.Add("--Chọn--");
            cbbgt.Items.Add("Nam");
            cbbgt.Items.Add("Nữ");
            cbbgt.SelectedIndex = 0; // Chọn mặc định là --Chọn--
        }
        private QuanLyKhachHang quanlyKhachHang = new QuanLyKhachHang();

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void add_Click(object sender, EventArgs e)
        {
            string name = nameAdd.Text;
            string gender = cbbgt.SelectedItem.ToString();
            string phone = phoneAdd.Text;
            string address = addressAdd.Text;
            string email = emailAdd.Text;
            string note = typekhAdd.SelectedItem.ToString();
            string cccd = cccdAdd.Text;
            string birthdateText = birthdayAdd.Text;
            if (IsPhoneNumberExist(phone))
            {
                MessageBox.Show("Số điện thoại đã tồn tại trong hệ thống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                phoneAdd.Focus();  // Đưa con trỏ chuột về ô nhập số điện thoại
                return;
            }

            // Kiểm tra trùng số CCCD trong cơ sở dữ liệu
            if (IsCCCDExist(cccd))
            {
                MessageBox.Show("Số CCCD đã tồn tại trong hệ thống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cccdAdd.Focus();  // Đưa con trỏ chuột về ô nhập số CCCD
                return;
            }
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nameAdd.Focus();  // Đưa con trỏ chuột về ô nhập tên
                return;
            }

            if (string.IsNullOrEmpty(phone) || !Regex.IsMatch(phone, @"^(09|03|08)\d{8}$"))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại hợp lệ (Bắt đầu bằng 09, 03, hoặc 08 và có 10 chữ số).", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                phoneAdd.Focus();  // Đưa con trỏ chuột về ô nhập số điện thoại
                return;
            }

            // Kiểm tra email hợp lệ
            if (string.IsNullOrEmpty(email) || !Regex.IsMatch(email, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
            {
                MessageBox.Show("Vui lòng nhập email hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                emailAdd.Focus();  // Đưa con trỏ chuột về ô nhập email
                return;
            }

            if (string.IsNullOrEmpty(note) || note == "--Chọn--")
            {
                MessageBox.Show("Vui lòng chọn loại khách hàng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                typekhAdd.Focus();  // Đưa con trỏ chuột về ComboBox loại khách hàng
                return;
            }

            if (gender == "--Chọn--")
            {
                MessageBox.Show("Vui lòng chọn giới tính.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbbgt.Focus();  // Đưa con trỏ chuột về ComboBox giới tính
                return;
            }
            // Kiểm tra nếu thông tin không hợp lệ
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("Vui lòng nhập tên và số điện thoại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra định dạng ngày sinh
            DateTime birthdate;
            if (!DateTime.TryParse(birthdateText, out birthdate))
            {
                MessageBox.Show("Ngày sinh không hợp lệ. Vui lòng nhập lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(address))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                addressAdd.Focus();  // Đưa con trỏ chuột về ô nhập địa chỉ
                return;
            }

            // Kiểm tra số CCCD có 12 chữ số
            if (string.IsNullOrEmpty(cccd) || !Regex.IsMatch(cccd, @"^\d{12}$"))
            {
                MessageBox.Show("Vui lòng nhập số CCCD hợp lệ (12 chữ số).", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cccdAdd.Focus();  // Đưa con trỏ chuột về ô nhập số CCCD
                return;
            }
            
            // Tạo kết nối với cơ sở dữ liệu
            SqlConnection con = connectDB.GetConnection();  // Sử dụng phương thức GetConnection từ class connectDB
            try
            {
                // Mở kết nối
                if (con.State == ConnectionState.Closed)
                    con.Open();

                // Câu lệnh SQL để thêm khách hàng
                string sql = @"INSERT INTO KhachHang (HOTEN, GIOITINH, SOCCCD, SODIENTHOAI, DIACHI, EMAIL, NGAYSINH, GHICHU) 
                               VALUES (@HOTEN, @GIOITINH,@SOCCCD, @SODIENTHOAI, @DIACHI, @EMAIL, @NGAYSINH, @GHICHU)";

                // Tạo SqlCommand
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@HOTEN", name);
                cmd.Parameters.AddWithValue("@GIOITINH", gender);
                cmd.Parameters.AddWithValue("@SODIENTHOAI", phone);
                cmd.Parameters.AddWithValue("@DIACHI", address);
                cmd.Parameters.AddWithValue("@EMAIL", email);
                cmd.Parameters.AddWithValue("@NGAYSINH", birthdate);
                cmd.Parameters.AddWithValue("@SOCCCD", cccd);
                cmd.Parameters.AddWithValue("@GHICHU", note);

                // Thực thi câu lệnh SQL
                cmd.ExecuteNonQuery();

                // Thông báo thành công
                MessageBox.Show("Khách hàng đã được thêm thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                // Đóng form
                this.Close();
            }
            catch (Exception ex)
            {
                // Hiển thị lỗi nếu có
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Đảm bảo đóng kết nối
                con.Close();
            }
        }
        private bool IsCCCDExist(string cccd)
        {
            // Tạo kết nối
            using (SqlConnection con = connectDB.GetConnection())
            {
                try
                {
                    // Kiểm tra trạng thái kết nối và mở nếu cần
                    if (con.State == ConnectionState.Closed)
                        con.Open();

                    // Câu lệnh SQL kiểm tra trùng số CCCD
                    string sql = "SELECT COUNT(*) FROM KhachHang WHERE SOCCCD = @SOCCCD";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@SOCCCD", cccd);

                    // Thực hiện truy vấn và lấy kết quả
                    int count = (int)cmd.ExecuteScalar();

                    return count > 0;  // Nếu có khách hàng có số CCCD trùng thì trả về true
                }
                catch (Exception ex)
                {
                    // Hiển thị lỗi nếu có
                    MessageBox.Show("Lỗi kiểm tra số CCCD: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                // Kết nối sẽ tự đóng khi rời khỏi using block
            }
        }

        private bool IsPhoneNumberExist(string phone)
        {
            // Tạo kết nối
            using (SqlConnection con = connectDB.GetConnection())
            {
                try
                {
                    // Kiểm tra trạng thái kết nối và mở nếu cần
                    if (con.State == ConnectionState.Closed)
                        con.Open();

                    // Câu lệnh SQL kiểm tra trùng số điện thoại
                    string sql = "SELECT COUNT(*) FROM KhachHang WHERE SODIENTHOAI = @SODIENTHOAI";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@SODIENTHOAI", phone);

                    // Thực hiện truy vấn và lấy kết quả
                    int count = (int)cmd.ExecuteScalar();

                    return count > 0;  // Nếu có khách hàng có số điện thoại trùng thì trả về true
                }
                catch (Exception ex)
                {
                    // Hiển thị lỗi nếu có
                    MessageBox.Show("Lỗi kiểm tra số điện thoại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                // Kết nối sẽ tự đóng khi rời khỏi using block
            }
        }

    }
}
