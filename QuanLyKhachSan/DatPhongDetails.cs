using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class DatPhongDetails : Form
    {
        private int phongId;
        private string connectionString = "Data Source=.;Initial Catalog=QUANLYKHACHSAN;Integrated Security=True";

        public DatPhongDetails(int phongId, string soPhong, string loaiPhong, decimal gia)
        {
            InitializeComponent();
            this.phongId = phongId;

            lblSoPhong.Text = "Phòng: " + soPhong;
            lblLoaiPhong.Text = "Loại phòng: " + loaiPhong;
            lblGia.Text = "Giá: " + gia.ToString("N0") + " VNĐ";
        }

        private void DatPhongDetails_Load(object sender, EventArgs e)
        {
            LoadKhachHang();
            LoadNhanVien();

            ngayden.Format = DateTimePickerFormat.Custom;
            ngayden.CustomFormat = "dd/MM/yyyy";
            ngaydi.Format = DateTimePickerFormat.Custom;
            ngaydi.CustomFormat = "dd/MM/yyyy";

            ngayden.Value = DateTime.Today;
            ngaydi.Value = DateTime.Today.AddDays(1);
        }

        private void LoadKhachHang()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT KHACHHANGID, HOTEN FROM KhachHang", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cbbkhachang.DataSource = dt;
                cbbkhachang.DisplayMember = "HOTEN";
                cbbkhachang.ValueMember = "KHACHHANGID";
            }
        }

        private void LoadNhanVien()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT HOTEN FROM NhanVien", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cbbnhanvien.DataSource = dt;
                cbbnhanvien.DisplayMember = "HOTEN";
            }
        }

        private void btndatphong_Click(object sender, EventArgs e)
        {
            if (ngayden.Value >= ngaydi.Value)
            {
                MessageBox.Show("❌ Ngày đi phải sau ngày đến.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int khachHangId = Convert.ToInt32(cbbkhachang.SelectedValue);
            string nhanVienXuLi = cbbnhanvien.Text;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // 1. Insert vào bảng Đặt Phòng
                string insertQuery = @"
            INSERT INTO DatPhong (KHACHHANGID, PHONGID, NGAYDAT, NGAYDEN, NGAYDI, NHANVIENXULI, TINHTRANGDAT)
            VALUES (@KHACHHANGID, @PHONGID, GETDATE(), @NGAYDEN, @NGAYDI, @NHANVIENXULI, N'ĐANG ĐẶT')";

                using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@KHACHHANGID", khachHangId);
                    cmd.Parameters.AddWithValue("@PHONGID", phongId);
                    cmd.Parameters.AddWithValue("@NGAYDEN", ngayden.Value);
                    cmd.Parameters.AddWithValue("@NGAYDI", ngaydi.Value);
                    cmd.Parameters.AddWithValue("@NHANVIENXULI", nhanVienXuLi);
                    cmd.ExecuteNonQuery();
                }

                // 2. Cập nhật trạng thái phòng = 'Đã đặt'
                string updateQuery = "UPDATE Phong SET TINHTRANG = N'Đã đặt' WHERE PHONGID = @PHONGID";
                using (SqlCommand updateCmd = new SqlCommand(updateQuery, conn))
                {
                    updateCmd.Parameters.AddWithValue("@PHONGID", phongId);
                    updateCmd.ExecuteNonQuery();
                }

                conn.Close();
            }

            MessageBox.Show("✅ Đặt phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }


        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
