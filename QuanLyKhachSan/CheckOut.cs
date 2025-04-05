using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKhachSan.Library;

namespace QuanLyKhachSan
{
    public partial class CheckOut: Form
    {
        public CheckOut()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            string query = "SELECT * FROM DatPhong";
            DatabaseHelper db = DatabaseHelper.Instance;
            DataTable dataTable = db.GetData(query);
            if (dataTable != null)
            {
                dataGridView1.DataSource = dataTable;
            }
        }
        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabDanhSach;
        }

        private void btnIn_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DialogThemHoaDon dialogThemHoaDon = new DialogThemHoaDon();
            dialogThemHoaDon.ShowDialog();
            dialogThemHoaDon.StartPosition = FormStartPosition.Manual;
            dialogThemHoaDon.Location = new Point(
    this.Location.X + this.Width + 10,
    this.Location.Y + (this.Height - dialogThemHoaDon.Height) / 2
);

        }

        private void CheckOut_Load(object sender, EventArgs e)
        {

        }
    }
}
