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
    public partial class ThongKe: Form
    {
        private DatabaseHelper dbHelper;
        public ThongKe()
        {
            dbHelper = new DatabaseHelper();
            InitializeComponent();
            LoadThongKePhong();

        }
        private void HienThiNgayGio()
        {
            // Lấy ngày giờ hiện tại
            DateTime now = DateTime.Now;

            // Định dạng: 07/04/2025 10:30:45
            labelNgayGioHienTai.Text = now.ToString("dd/MM/yyyy HH:mm:ss");
        }
        private void LoadThongKePhong()
        {
            // Câu lệnh SQL thống kê
            string queryTong = "SELECT COUNT(*) AS SoLuong FROM Phong";
            string queryTrong = "SELECT COUNT(*) AS SoLuong FROM Phong WHERE TINHTRANG = N'Trống'";

            // Lấy tổng số phòng
            DataTable dtTong = dbHelper.GetData(queryTong);
            if (dtTong != null && dtTong.Rows.Count > 0)
            {
                txtTongSoPhong_FormTK.Text = dtTong.Rows[0]["SoLuong"].ToString();
            }

            // Lấy số phòng còn trống
            DataTable dtTrong = dbHelper.GetData(queryTrong);
            if (dtTrong != null && dtTrong.Rows.Count > 0)
            {
                txtPhongTrong_FormTK.Text = dtTrong.Rows[0]["SoLuong"].ToString();
            }
            HienThiNgayGio();
        }
        private void LoadThongKePhongChiTiet()
        {
            // Câu lệnh SQL thống kê
            string queryTong = "SELECT COUNT(*) AS SoLuong FROM Phong";
            string queryTrong = "SELECT COUNT(*) AS SoLuong FROM Phong WHERE TINHTRANG = N'Trống'";

            // Lấy tổng số phòng
            DataTable dtTong = dbHelper.GetData(queryTong);
            if (dtTong != null && dtTong.Rows.Count > 0)
            {
                labelTongPhong_FormTK_TabP.Text = dtTong.Rows[0]["SoLuong"].ToString();
            }

            // Lấy số phòng còn trống
            DataTable dtTrong = dbHelper.GetData(queryTrong);
            if (dtTrong != null && dtTrong.Rows.Count > 0)
            {
                labelPhongTrong_FormTK_TabP.Text = dtTrong.Rows[0]["SoLuong"].ToString();
            }
            // Lấy ngày giờ hiện tại
            DateTime now = DateTime.Now;

            // Định dạng: 07/04/2025 10:30:45
            labelNgayGio_FormTK_TabP.Text = now.ToString("dd/MM/yyyy HH:mm:ss");
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPhongTrong_FormTK_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPagePhong;
            LoadThongKePhongChiTiet();

        }

        private void btnCapNhat_FormChiTiet_Click(object sender, EventArgs e)
        {
            LoadThongKePhong();

            // Lấy ngày giờ hiện tại
            DateTime now = DateTime.Now;
            // Hiển thị thông báo
            MessageBox.Show($"Đã cập nhật thành công lúc {now.ToString("dd/MM/yyyy HH:mm:ss")}", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnPhongTrong_FormTK_TP_Click(object sender, EventArgs e)
        {
            // Câu lệnh SQL để lấy danh sách các phòng trống
            string queryPhongTrong = "SELECT PHONGID, SOPHONG, LOAIPHONGID, GIA, TANGID, DIENTICH, SONGUOITOIDA, TRANGBI, TINHTRANG FROM Phong WHERE TINHTRANG = N'Trống'";

            // Lấy dữ liệu phòng trống
            DataTable dtPhongTrong = dbHelper.GetData(queryPhongTrong);

            // Gán dữ liệu cho DataGridView
            if (dtPhongTrong != null)
            {
                dataGridViewPhong_FormTK.DataSource = dtPhongTrong;
            }
            LoadThongKePhongChiTiet();
        }

        private void btnPhongKhachDat_FormTK_TP_Click(object sender, EventArgs e)
        {
            // Câu lệnh SQL để lấy danh sách các phòng trống
            string queryPhongTrong = "SELECT PHONGID, SOPHONG, LOAIPHONGID, GIA, TANGID, DIENTICH, SONGUOITOIDA, TRANGBI, TINHTRANG FROM Phong WHERE TINHTRANG = N'Đã Đặt'";

            // Lấy dữ liệu phòng trống
            DataTable dtPhongTrong = dbHelper.GetData(queryPhongTrong);

            // Gán dữ liệu cho DataGridView
            if (dtPhongTrong != null)
            {
                dataGridViewPhong_FormTK.DataSource = dtPhongTrong;
            }
            LoadThongKePhongChiTiet();

        }
    }
}
