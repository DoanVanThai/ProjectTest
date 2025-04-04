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

namespace QuanLyKhachSan
{
    public partial class QuanLyKhachHang: Form
    {
        public QuanLyKhachHang()
        {
            InitializeComponent();
        }

        private void QuanLyKhachHang_Load(object sender, EventArgs e)
        {
            // Cài đặt văn bản placeholder mặc định
         
        }

        private void textBox1_Paint(object sender, PaintEventArgs e)
        {
            // Hiển thị placeholder nếu TextBox chưa có dữ liệu và không đang có focus
            if (string.IsNullOrEmpty(textBox1.Text) && !textBox1.Focused)
            {
                using (Brush brush = new SolidBrush(Color.Gray))
                {
                    e.Graphics.DrawString(textBox1.Text, textBox1.Font, brush, new PointF(5, 5));
                }
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            // Khi TextBox được focus, xóa placeholder
            if (textBox1.Text == "Nhập tên khách hàng...")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;  // Màu chữ đen khi bắt đầu nhập
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            // Khi TextBox mất focus và không có dữ liệu, hiển thị lại placeholder
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Text = "Nhập tên khách hàng...";
                textBox1.ForeColor = Color.Gray;  // Màu xám cho placeholder
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
            textBox1.Text = "Nhập tên khách hàng...";
            textBox1.ForeColor = Color.Gray;  // Màu xám cho placeholder
        }
    }
}