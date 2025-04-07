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
            cbbKieuTT_FormChiTiet.SelectedIndex = 0;
            cbbTrangThai_FormChiTiet.SelectedIndex = 0;
        }
        private void LoadData()
        {
            string query = "SELECT * FROM HoaDonTongHop";
            DataTable dataTable = dbHelper.GetData(query);
            if (dataTable != null)
            {
                dataGridView_FormDanhSach.DataSource = dataTable;
                // Tùy chỉnh hiển thị các cột
                dataGridView_FormDanhSach.EnableHeadersVisualStyles = false;
                dataGridView_FormDanhSach.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkBlue;
                dataGridView_FormDanhSach.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dataGridView_FormDanhSach.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9 , FontStyle.Bold);
                dataGridView_FormDanhSach.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dataGridView_FormDanhSach.Columns["HOADONID"].HeaderText = "ID";
                dataGridView_FormDanhSach.Columns["NGAYLAP"].HeaderText = "Ngày Lập";
                dataGridView_FormDanhSach.Columns["DATPHONGID"].HeaderText = "ĐặtPhòngID";
                dataGridView_FormDanhSach.Columns["PHONGID"].HeaderText = "PhòngID";
                dataGridView_FormDanhSach.Columns["NGAYDEN"].HeaderText = "Ngày Đến";
                dataGridView_FormDanhSach.Columns["NGAYDI"].HeaderText = "Ngày Đi";
                dataGridView_FormDanhSach.Columns["GIA"].HeaderText = "Đơn giá";
                dataGridView_FormDanhSach.Columns["TIENPHONG"].HeaderText = "Tiền Phòng";
                dataGridView_FormDanhSach.Columns["SOLUONGDICHVU"].HeaderText = "SL Dịch Vụ";
                dataGridView_FormDanhSach.Columns["TIENDICHVU"].HeaderText = "Tiền DV";
                dataGridView_FormDanhSach.Columns["TINHTRANGTHANHTOAN"].HeaderText = "Trạng Thái";
                dataGridView_FormDanhSach.Columns["NGAYTHANHTOAN"].HeaderText = "Ngày TT";
                dataGridView_FormDanhSach.Columns["HINHTHUCTHANHTOAN"].HeaderText = "KIỂU TT";
                dataGridView_FormDanhSach.RowHeadersWidth = 25;  
                dataGridView_FormDanhSach.Columns["HOADONID"].Width = 30;
                dataGridView_FormDanhSach.Columns["SOLUONGDICHVU"].Width = 30;
                dataGridView_FormDanhSach.Columns["DATPHONGID"].Width = 70;
                dataGridView_FormDanhSach.Columns["TIENDICHVU"].Width = 83;
                dataGridView_FormDanhSach.Columns["TIENPHONG"].Width = 89;
                dataGridView_FormDanhSach.Columns["GIA"].Width = 90;
                dataGridView_FormDanhSach.Columns["NGAYDEN"].Width = 90;
                dataGridView_FormDanhSach.Columns["NGAYDI"].Width = 90;
                dataGridView_FormDanhSach.Columns["PHONGID"].Width = 57;
                dataGridView_FormDanhSach.Columns["NGAYLAP"].Width = 90;
                dataGridView_FormDanhSach.Columns["NGAYTHANHTOAN"].Width = 90;
                dataGridView_FormDanhSach.Columns["TINHTRANGTHANHTOAN"].Width = 122;
                dataGridView_FormDanhSach.Columns["HINHTHUCTHANHTOAN"].Width = 104;
            }
            if (!dataGridView_FormDanhSach.Columns.Contains("ChiTiet"))
            {
                DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
                btnColumn.Name = "ChiTiet";
                btnColumn.HeaderText = "";
                btnColumn.Text = "Chi tiết";
                btnColumn.UseColumnTextForButtonValue = true;
                btnColumn.Width = 60;
                btnColumn.DefaultCellStyle.BackColor = Color.LightSkyBlue;
                dataGridView_FormDanhSach.Columns.Add(btnColumn); 
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
            dialogThemHoaDon.HoaDonAdded += DialogThemHoaDon_HoaDonAdded;
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
            txtDatPhongID_FormDanhSach.Visible = check;
            txtMaKH_FormDanhSach.Visible = check;
            btnDongTimKiem_FormDanhSach.Visible = check;
        }
        private void HandleFilter(Boolean check)
        {
            toolStripLabelTrangThai.Visible = check;
            toolStripLabelKieuThanhToan.Visible = check;
            cbbTrangThai_FormDanhSach.Visible = check;
            cbbKieuTT_FormDanhSach.Visible = check;
            if (check)
            {
                // Khi hiện bộ lọc, reset lại lựa chọn
                cbbTrangThai_FormDanhSach.SelectedIndex = 0;
                cbbKieuTT_FormDanhSach.SelectedIndex = 0;
            }
        }
        private void DialogThemHoaDon_HoaDonAdded(object sender, EventArgs e)
        {
            // Khi hóa đơn đã được thêm thành công, load lại dữ liệu
            LoadData();
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
            string trangThai = cbbTrangThai_FormDanhSach.SelectedItem?.ToString();
            string kieuTT = cbbKieuTT_FormDanhSach.SelectedItem?.ToString();

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
            dataGridView_FormDanhSach.DataSource = filteredData;
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
            if (e.RowIndex >= 0 && dataGridView_FormDanhSach.Columns[e.ColumnIndex].Name == "ChiTiet")
            {
                // Lấy dòng được chọn
                DataGridViewRow selectedRow = dataGridView_FormDanhSach.Rows[e.RowIndex];

                string tinhTrang = selectedRow.Cells["TINHTRANGTHANHTOAN"].Value?.ToString();
                if(tinhTrang == "Đã thanh toán")
                {
                    OnlyRead(true);
                }
                // Chuyển Tab
                tabControl.SelectedTab = tabChiTiet;
                string DatPhongID = selectedRow.Cells["DATPHONGID"].Value?.ToString();

                // Thêm dữ liệu vào những ô đơn giản
                txtDonGia_FormChiTiet.Text = selectedRow.Cells["GIA"].Value?.ToString();
                txtHoaDonID_FormChiTiet.Text = selectedRow.Cells["HOADONID"].Value?.ToString();
                txtDatPhongID_FormChiTiet.Text = selectedRow.Cells["DATPHONGID"].Value?.ToString();
                txtPhongID_FormChiTiet.Text = selectedRow.Cells["PHONGID"].Value?.ToString();

                //Thêm dữ liệu vào ô DateTime
                if (DateTime.TryParse(selectedRow.Cells["NGAYLAP"].Value?.ToString(), out DateTime ngayLap))
                    dtpNgayLap_FormChiTiet.Value = ngayLap;

                if (DateTime.TryParse(selectedRow.Cells["NGAYDEN"].Value?.ToString(), out DateTime ngayDen))
                    dtpNgayDen_FormChiTiet.Value = ngayDen;

                if (DateTime.TryParse(selectedRow.Cells["NGAYDI"].Value?.ToString(), out DateTime ngayDi))
                    dtpNgayDi_FormChiTiet.Value = ngayDi;

                if (DateTime.TryParse(selectedRow.Cells["NGAYTHANHTOAN"].Value?.ToString(), out DateTime ngayTT))
                    dtpNgayTT_FormChiTiet.Value = ngayTT;

                //Tính số ngày ở 
                TimeSpan soNgayO = ngayDi.Date - ngayDen.Date;
                txtSoNgayO_FormChiTiet.Text = soNgayO.Days.ToString();

                // Tính Toán Tiền Phòng = Đơn giá x số ngày
                decimal gia = 0;
                if (decimal.TryParse(selectedRow.Cells["GIA"].Value?.ToString(), out decimal parsedGia))
                {
                    gia = parsedGia;
                }
                decimal tienPhong = gia * soNgayO.Days;
                txtTienPhong_FormChiTiet.Text = tienPhong.ToString();
                LoadDichVu(DatPhongID);


                // Tính toán Tổng Tiền = Tiền Phòng + Tiền Dịch Vụ
                decimal tienDichVu = 0;
                if (!decimal.TryParse(txtTienDV_FormChiTiet.Text, out tienDichVu))
                {
                    tienDichVu = 0; // Hoặc bạn có thể hiện thông báo lỗi
                }
                decimal Tong = tienPhong + tienDichVu;
                txtTongTien_FormChiTiet.Text = Tong.ToString();

                // Gán giá trị trạng thái thanh toán vào ComboBox
                if (cbbTrangThai_FormChiTiet.Items.Contains(tinhTrang))
                    cbbTrangThai_FormChiTiet.SelectedItem = tinhTrang;

                // Gán giá trị kiểu thanh toán vào ComboBox
                string hinhThuc = selectedRow.Cells["HINHTHUCTHANHTOAN"].Value?.ToString();
                if (cbbKieuTT_FormChiTiet.Items.Contains(hinhThuc))
                    cbbKieuTT_FormChiTiet.SelectedItem = hinhThuc;
            }
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtPhongID_FormChiTiet_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHoaDonID_FormChiTiet_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpNgayTT_FormChiTiet_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cbbTrangThai_FormChiTiet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbbKieuTT_FormChiTiet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtTienDV_FormChiTiet_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTongTien_FormChiTiet_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTienPhong_FormChiTiet_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSoNgayO_FormChiTiet_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDonGia_FormChiTiet_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSLDV_FormChiTiet_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpNgayLap_FormChiTiet_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpNgayDen_FormChiTiet_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpNgayDi_FormChiTiet_ValueChanged(object sender, EventArgs e)
        {

        }
        private void LoadDichVu(string datPhongId)
        {
            string queryDV = @"
                SELECT 
                    dv.TENDICHVU AS [Tên Dịch Vụ],
                    ddv.GIA AS [Giá],
                    ddv.SOLUONG AS [SL],
                    ddv.NGAYDAT AS [Ngày Đặt],
                    (ddv.GIA * ddv.SOLUONG) AS [Thành Tiền]
                FROM DatDichVu ddv
                JOIN DichVu dv ON ddv.DICHVUID = dv.DICHVUID
                WHERE ddv.DATPHONGID = @DatPhongID
            ";

            SqlParameter[] paramDV = new SqlParameter[]
            {
                new SqlParameter("@DatPhongID", datPhongId)
            };

            DataTable dvTable = dbHelper.GetData(queryDV, paramDV);
            if (dvTable != null && dvTable.Rows.Count > 0)
            {
                dataGridView_FormChiTiet.DataSource = dvTable;
                // Tính tổng số lượng dịch vụ và tổng tiền dịch vụ
                int tongSoLuongDV = 0;
                decimal tongTienDV = 0;

                foreach (DataRow row in dvTable.Rows)
                {
                    int soLuong = Convert.ToInt32(row["SL"]);
                    decimal thanhTien = Convert.ToDecimal(row["Thành Tiền"]);

                    tongSoLuongDV += soLuong;
                    tongTienDV += thanhTien;
                    txtSLDV_FormChiTiet.Text = tongSoLuongDV.ToString();
                    txtTienDV_FormChiTiet.Text = tongTienDV.ToString();
                }

            }
            else
            {
                MessageBox.Show("Không tìm thấy dịch vụ nào đã sử dụng cho đặt phòng này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView_FormChiTiet.DataSource = null;
            }
        }
        private void OnlyRead(bool check)
        {
            txtHoaDonID_FormChiTiet.Enabled = !check;
            txtDatPhongID_FormChiTiet.Enabled = !check;
            txtPhongID_FormChiTiet.Enabled = !check;
            dtpNgayDen_FormChiTiet.Enabled = !check;
            dtpNgayDi_FormChiTiet.Enabled = !check;
            dtpNgayLap_FormChiTiet.Enabled = !check;
            dtpNgayTT_FormChiTiet.Enabled = !check;
            txtDonGia_FormChiTiet.Enabled = !check;
            txtSoNgayO_FormChiTiet.Enabled = !check;
            txtTienPhong_FormChiTiet.Enabled = !check;
            txtTienDV_FormChiTiet.Enabled = !check;
            txtSLDV_FormChiTiet.Enabled = !check;
            txtTongTien_FormChiTiet.Enabled = !check;
            cbbKieuTT_FormChiTiet.Enabled = !check;
            cbbTrangThai_FormChiTiet.Enabled = !check;
            btnThanhToan_FormChiTiet.Enabled = !check;
            labelOnlyRead.Visible = check;
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
