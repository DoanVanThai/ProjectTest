using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class DangKi: Form
    {
        public DangKi()
        {
            InitializeComponent();
            dkconfirmpass.Enabled = true;
            dkpass.Enabled = true;
            dkuser.Enabled = true;  
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Login dangNhapForm = new Login();
            dangNhapForm.Show();
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Close(); 
        }
    }
}
