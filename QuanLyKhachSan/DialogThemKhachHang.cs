using System;
using System.Data;
using System.Data.SqlClient;
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
    }
}
