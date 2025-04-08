using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class Login: Form
    {
        public Login()
        {
            InitializeComponent();
            lguser.Enabled = true; 
            lgpass.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
              
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {
            DangKi dangKiForm = new DangKi();
            dangKiForm.Show();
        }

        private void lgpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = lguser.Text.Trim();
            string password = lgpass.Text;

            // Kiểm tra đầu vào
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lguser.Focus();
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lgpass.Focus();
                return;
            }

            try
            {
                using (SqlConnection con = connectDB.GetConnection())
                {
                    string query = "SELECT * FROM TaiKhoan WHERE TenDangNhap = @username AND MatKhau = @password";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password); // Có thể thêm mã hóa nếu cần

                    SqlDataReader reader = cmd.ExecuteReader(); 

                    if (reader.HasRows)
                    {

                        MessageBox.Show("Đăng nhập thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Ẩn form đăng nhập, mở form chính tùy vai trò
                        this.Hide();
                        Index mainForm = new Index(); // thay bằng form của bạn
                        mainForm.Show();
                          
                        // Đảm bảo thoát chương trình sau khi form chính đóng
                        mainForm.FormClosed += (s, args) => Application.Exit();
                    }
                    else
                    {
                        MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
