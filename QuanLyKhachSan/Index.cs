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
    public partial class Index: Form
    {
        public Index()
        {
            InitializeComponent();
            OpenChildForm(new Home());
            label1.Text = "Trang chủ";
        } 

        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close(); 
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel4.Controls.Add(childForm);
            panel4.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLyPhong());
            label1.Text = "Quản lý phòng";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLyKhachHang());
            label1.Text = "Quản lý khách hàng";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLyNhanVien());
            label1.Text = "Quản lý nhân viên";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn đã nhấn nút Đặt phòng"); // Kiểm tra
            OpenChildForm(new DatPhong());
            label1.Text = "Đặt phòng";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DatDichVu());
            label1.Text = "Đặt dịch vụ cho khách";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLyDichVu());
            label1.Text = "Quản lý dịch vụ";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ThongKe());
            label1.Text = "Thống kê";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CheckOut());
            label1.Text = "Check out";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Index_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Home());
            label1.Text = "Home";
        }
    }
}
