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
        connectDB db = new connectDB(); 
        SqlConnection con;
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
            string sqlstr = "select a.AuthorID, Name, Address, Gender, Birthday, Phone, b.Quantity " +
                "from Authors a join Books b on a.AuthorID = b.AuthorID";
            //string sqlcbb = "select AuthorID, Quantity from Books";
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                cmd = new SqlCommand(sqlstr, con);
                adt = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adt.Fill(dt);
                grvkh.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
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
            searchName.Text = "Nhập tên khách hàng...";
            searchName.ForeColor = Color.Gray;  // Màu xám cho placeholder
            searchMKH.Text = "Nhập mã khách hàng...";
            searchMKH.ForeColor = Color.Gray;  // Màu xám cho placeholder
            searchPhoneNumber.Text = "Nhập số điện thoại...";
            searchPhoneNumber.ForeColor = Color.Gray;
        }

        private void searchName_Enter(object sender, EventArgs e)
        {
            if (searchName.Text == "Nhập tên khách hàng...")
            {
                searchName.Text = "";
                searchName.ForeColor = Color.Black;  // Màu chữ đen khi bắt đầu nhập
            }
        }

        private void searchName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(searchName.Text))
            {
                searchName.Text = "Nhập tên khách hàng...";
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
    }
}