using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class DialogEditKhachHang: Form
    {
        public DialogEditKhachHang()
        {
            InitializeComponent();
            genderEdit.Items.Add("--Chọn--");
            genderEdit.Items.Add("Nam");
            genderEdit.Items.Add("Nữ");
        }
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string CCCD { get; set; }
        public string Note { get; set; }
        public DateTime BirthDate { get; set; }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void DialogEditKhachHang_Load(object sender, EventArgs e)
        {
            // Khi form được mở, thiết lập các giá trị vào các điều khiển
            
            customerNameEdit.Text = CustomerName;
            phoneEdit.Text = PhoneNumber;
            addressEdit.Text = Address;
            emailEdit.Text = Email;
            cccdEdit.Text = CCCD;
            typekhEdit.Text = Note;
            genderEdit.SelectedItem = Gender;
            birthdayEdit.Value = BirthDate;
        
    }

        private void add_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các điều khiển
            string updatedName = customerNameEdit.Text;
            string updatedGender = genderEdit.SelectedItem.ToString();
            string updatedPhone = phoneEdit.Text;
            string updatedCCCD = cccdEdit.Text;
            string updatedAddress = addressEdit.Text;
            string updatedEmail = emailEdit.Text;
            string updatedNote = typekhEdit.Text;
            DateTime updatedBirthDate = birthdayEdit.Value;
            //if (IsPhoneNumberExist(updatedPhone))
            //{
            //    MessageBox.Show("Số điện thoại đã tồn tại trong hệ thống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    phoneEdit.Focus();  // Đưa con trỏ chuột về ô nhập số điện thoại
            //    return;
            //}

            //// Kiểm tra trùng số CCCD trong cơ sở dữ liệu
            //if (IsCCCDExist(updatedCCCD))
            //{
            //    MessageBox.Show("Số CCCD đã tồn tại trong hệ thống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    cccdEdit.Focus();  // Đưa con trỏ chuột về ô nhập số CCCD
            //    return;
            //}
            if (string.IsNullOrEmpty(updatedName))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                customerNameEdit.Focus();  // Đưa con trỏ chuột về ô nhập tên
                return;
            }

            if (string.IsNullOrEmpty(updatedPhone) || !Regex.IsMatch(updatedPhone, @"^(09|03|08)\d{8}$"))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại hợp lệ (Bắt đầu bằng 09, 03, hoặc 08 và có 10 chữ số).", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                phoneEdit.Focus();  // Đưa con trỏ chuột về ô nhập số điện thoại
                return;
            }

            // Kiểm tra email hợp lệ
            if (string.IsNullOrEmpty(updatedEmail) || !Regex.IsMatch(updatedEmail, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
            {
                MessageBox.Show("Vui lòng nhập email hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                emailEdit.Focus();  // Đưa con trỏ chuột về ô nhập email
                return;
            }


            if (string.IsNullOrEmpty(updatedNote) || updatedNote == "--Chọn--")
            {
                MessageBox.Show("Vui lòng chọn loại khách hàng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                typekhEdit.Focus();  // Đưa con trỏ chuột về ComboBox loại khách hàng
                return;
            }

            if (updatedGender == "--Chọn--")
            {
                MessageBox.Show("Vui lòng chọn giới tính.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                genderEdit.Focus();  // Đưa con trỏ chuột về ComboBox giới tính
                return;
            }
            if (string.IsNullOrEmpty(updatedAddress))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                addressEdit.Focus();  // Đưa con trỏ chuột về ô nhập địa chỉ
                return;
            }

            // Kiểm tra số CCCD có 12 chữ số
            if (string.IsNullOrEmpty(updatedCCCD) || !Regex.IsMatch(updatedCCCD, @"^\d{12}$"))
            {
                MessageBox.Show("Vui lòng nhập số CCCD hợp lệ (12 chữ số).", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cccdEdit.Focus();  // Đưa con trỏ chuột về ô nhập số CCCD
                return;
            }
            // Tiến hành cập nhật vào cơ sở dữ liệu
            // Câu lệnh SQL cập nhật thông tin khách hàng
            string sqlUpdate = @"
            UPDATE KhachHang 
            SET HOTEN = @HOTEN, GIOITINH = @GIOITINH, SOCCCD = @SOCCCD, SODIENTHOAI = @SODIENTHOAI, 
                DIACHI = @DIACHI, EMAIL = @EMAIL, NGAYSINH = @NGAYSINH, GHICHU = @GHICHU
            WHERE KHACHHANGID = @KHACHHANGID";

            SqlConnection con = connectDB.GetConnection();
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                SqlCommand cmd = new SqlCommand(sqlUpdate, con);
                cmd.Parameters.AddWithValue("@HOTEN", updatedName);
                cmd.Parameters.AddWithValue("@GIOITINH", updatedGender);
                cmd.Parameters.AddWithValue("@SODIENTHOAI", updatedPhone);
                cmd.Parameters.AddWithValue("@DIACHI", updatedAddress);
                cmd.Parameters.AddWithValue("@EMAIL", updatedEmail);
                cmd.Parameters.AddWithValue("@SOCCCD", updatedCCCD);
                cmd.Parameters.AddWithValue("@NGAYSINH", updatedBirthDate);
                cmd.Parameters.AddWithValue("@GHICHU", updatedNote);

                // Lấy ID khách hàng từ form chính để cập nhật đúng khách hàng
                cmd.Parameters.AddWithValue("@KHACHHANGID", CustomerId); // Cần truyền tham số này

                cmd.ExecuteNonQuery();

                MessageBox.Show("Thông tin khách hàng đã được cập nhật.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
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
        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
