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
        private DatabaseHelper dbHelper;
        private bool isFilterVisible = false;
        public CheckOut()
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper();
            LoadData();
            HandleSearch(false);
            HandleFilter(isFilterVisible);
        }
        private void LoadData()
        {
            string query = "SELECT * FROM HoaDonTongHop";
            DataTable dataTable = dbHelper.GetData(query);
            if (dataTable != null)
            {
                dataGridView1.DataSource = dataTable;
                // Tùy chỉnh hiển thị các cột
                dataGridView1.EnableHeadersVisualStyles = false;
                dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkBlue;
                dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9 , FontStyle.Bold);
                dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dataGridView1.Columns["HOADONID"].HeaderText = "ID";
                dataGridView1.Columns["NGAYLAP"].HeaderText = "Ngày Lập";
                dataGridView1.Columns["DATPHONGID"].HeaderText = "ĐặtPhòngID";
                dataGridView1.Columns["PHONGID"].HeaderText = "PhòngID";
                dataGridView1.Columns["NGAYDEN"].HeaderText = "Ngày Đến";
                dataGridView1.Columns["NGAYDI"].HeaderText = "Ngày Đi";
                dataGridView1.Columns["GIA"].HeaderText = "Đơn giá";
                dataGridView1.Columns["TIENPHONG"].HeaderText = "Tiền Phòng";
                dataGridView1.Columns["SOLUONGDICHVU"].HeaderText = "SL Dịch Vụ";
                dataGridView1.Columns["TIENDICHVU"].HeaderText = "Tiền DV";
                dataGridView1.Columns["TINHTRANGTHANHTOAN"].HeaderText = "Trạng Thái";
                dataGridView1.Columns["NGAYTHANHTOAN"].HeaderText = "Ngày TT";
                dataGridView1.Columns["HINHTHUCTHANHTOAN"].HeaderText = "KIỂU TT";
                dataGridView1.RowHeadersWidth = 25;  
                dataGridView1.Columns["HOADONID"].Width = 30;
                dataGridView1.Columns["SOLUONGDICHVU"].Width = 30;
                dataGridView1.Columns["DATPHONGID"].Width = 70;
                dataGridView1.Columns["TIENDICHVU"].Width = 83;
                dataGridView1.Columns["TIENPHONG"].Width = 89;
                dataGridView1.Columns["GIA"].Width = 90;
                dataGridView1.Columns["NGAYDEN"].Width = 90;
                dataGridView1.Columns["NGAYDI"].Width = 90;
                dataGridView1.Columns["PHONGID"].Width = 57;
                dataGridView1.Columns["NGAYLAP"].Width = 90;
                dataGridView1.Columns["NGAYTHANHTOAN"].Width = 90;
                dataGridView1.Columns["TINHTRANGTHANHTOAN"].Width = 122;
                dataGridView1.Columns["HINHTHUCTHANHTOAN"].Width = 104;
            }
            if (!dataGridView1.Columns.Contains("ChiTiet"))
            {
                DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
                btnColumn.Name = "ChiTiet";
                btnColumn.HeaderText = "";
                btnColumn.Text = "Chi tiết";
                btnColumn.UseColumnTextForButtonValue = true;
                btnColumn.Width = 60;
                btnColumn.DefaultCellStyle.BackColor = Color.LightSkyBlue;
                dataGridView1.Columns.Add(btnColumn); 
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnTaoHoaDon_Click(object sender, EventArgs e)
        {
            DialogThemHoaDon dialogThemHoaDon = new DialogThemHoaDon();
            dialogThemHoaDon.ShowDialog();
            dialogThemHoaDon.StartPosition = FormStartPosition.Manual;
            dialogThemHoaDon.Location = new Point(
            this.Location.X + this.Width + 10,
            this.Location.Y + (this.Height - dialogThemHoaDon.Height) / 2
            );
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            HandleSearch(true);
        }

        private void btnDongTimKiem_Click(object sender, EventArgs e)
        {
            HandleSearch(false);
        }
        private void HandleSearch(Boolean check)
        {
            toolStripLabelDatPhongID.Visible = check;
            toolStripLabelMaKH.Visible = check;
            txtDatPhongID.Visible = check;
            txtMaKH.Visible = check;
            btnDongTimKiem.Visible = check;
        }
        private void HandleFilter(Boolean check)
        {
            toolStripLabelTrangThai.Visible = check;
            toolStripLabelKieuThanhToan.Visible = check;
            cbbTrangThai.Visible = check;
            cbbKieuTT.Visible = check;
            if (check)
            {
                // Khi hiện bộ lọc, reset lại lựa chọn
                cbbTrangThai.SelectedIndex = 0;
                cbbKieuTT.SelectedIndex = 0;
            }
        }

        private void btnBoLoc_Click(object sender, EventArgs e)
        {
            isFilterVisible = !isFilterVisible;
            HandleFilter(isFilterVisible);


        }

        private void cbbTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void cbbKieuTT_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterData();
        }
        private void FilterData()
        {
            string trangThai = cbbTrangThai.SelectedItem?.ToString();
            string kieuTT = cbbKieuTT.SelectedItem?.ToString();

            // Nếu cả 2 đều là "Mặc định" hoặc null thì load toàn bộ
            if (string.IsNullOrEmpty(trangThai) || trangThai == "Chọn trạng thái")
                trangThai = null;
            if (string.IsNullOrEmpty(kieuTT) || kieuTT == "Chọn kiểu thanh toán")
                kieuTT = null;

            string query = "SELECT * FROM HoaDonTongHop WHERE 1=1";

            if (trangThai != null)
                query += $" AND TINHTRANGTHANHTOAN = N'{trangThai}'";

            if (kieuTT != null)
                query += $" AND HINHTHUCTHANHTOAN = N'{kieuTT}'";

            DataTable filteredData = dbHelper.GetData(query);
            dataGridView1.DataSource = filteredData;
            if (filteredData.Rows.Count == 0)
            {
                MessageBox.Show("Không có bản ghi nào thỏa mãn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Đảm bảo không xử lý header hoặc các cột khác
            if (e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "ChiTiet")
            {
                // Lấy dòng được chọn
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                tabControl.SelectedTab = tabChiTiet;
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
