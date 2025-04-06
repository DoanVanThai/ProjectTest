using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKhachSan.Library;

namespace QuanLyKhachSan
{
    public partial class DialogThemHoaDon : Form
    {
        private DatabaseHelper dbHelper;
        public DialogThemHoaDon()
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private decimal LayGiaPhongTheoID(string phongId)
        {
            string query = "SELECT GIA FROM Phong WHERE SOPHONG = @SoPhong";
            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@SoPhong", phongId)
            };

            DataTable result = dbHelper.GetData(query, parameters);

            if (result != null && result.Rows.Count > 0)
            {
                object giaValue = result.Rows[0]["GIA"];
                if (giaValue != DBNull.Value)
                {
                    return Convert.ToDecimal(giaValue);
                }
            }

            return 0; // Giá mặc định nếu không tìm thấy
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void DialogThemHoaDon_Load(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_FormThemHoaDon_Click(object sender, EventArgs e)
        {
            string datPhongId = txtDatPhongID_FormThemHoaDon.Text;

            if (string.IsNullOrEmpty(datPhongId))
            {
                MessageBox.Show("Vui lòng nhập Mã Đặt Phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string queryCheck = "SELECT * FROM DatPhong WHERE DATPHONGID = @DatPhongID AND TINHTRANGDAT = N'ĐANG ĐẶT'";
            SqlParameter[] paramCheck = new SqlParameter[]
            {
                new SqlParameter("@DatPhongID", datPhongId)
            };

            DataTable checkResult = dbHelper.GetData(queryCheck, paramCheck);

            if (checkResult == null || checkResult.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy đặt phòng đang đặt với ID đã nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }else
            {
                DataRow row = checkResult.Rows[0];
                // Ví dụ: Lấy thông tin khách hàng ID và tên nhân viên xử lý
                string khachHangID = row["KHACHHANGID"].ToString();
                string phongID = row["PHONGID"].ToString();
                DateTime ngayDen = Convert.ToDateTime(row["NGAYDEN"]);
                DateTime ngayDi = Convert.ToDateTime(row["NGAYDI"]);

                // Lấy giá bằng cách truy vấn trong bảng Phòng bằng ID:
                decimal gia = LayGiaPhongTheoID(phongID);
                txtDonGia_FormThemHoaDon.Text = gia.ToString();

                // Lấy số ngày ở bằng cách dùng NgayDi - NgayDen
                TimeSpan soNgayO = ngayDi.Date - ngayDen.Date;
                txtSoNgayO_FormThemHoaDon.Text = soNgayO.Days.ToString();

                // Tiền Phòng = Đơn giá x số ngày
                decimal tienPhong = gia * soNgayO.Days;
                txtTienPhong_FormThemHoaDon.Text = tienPhong.ToString();

                // Hiển thị thông tin khác lên TextBox
                txtPhongID_FormThemHoaDon.Text = phongID;
                dtpNgayDen_FormThemHoaDon.Value = ngayDen;
                dtpNgayDi_FormThemHoaDon.Value = ngayDi;
            }
            // Nếu tìm thấy thì tiếp tục lấy dịch vụ
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
                dataGridView_FormThemHoaDon.DataSource = dvTable;
                // Tính tổng số lượng dịch vụ và tổng tiền dịch vụ
                int tongSoLuongDV = 0;
                decimal tongTienDV = 0;

                foreach (DataRow row in dvTable.Rows)
                {
                    int soLuong = Convert.ToInt32(row["SL"]);
                    decimal thanhTien = Convert.ToDecimal(row["Thành Tiền"]);

                    tongSoLuongDV += soLuong;
                    tongTienDV += thanhTien;
                    txtSoLuongDichVu_FormThemHoaDon.Text = tongSoLuongDV.ToString();
                    txtTienDichVu_FormThemHoaDon.Text = tongTienDV.ToString();
                }

            }
            else
            {
                MessageBox.Show("Không tìm thấy dịch vụ nào đã sử dụng cho đặt phòng này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView_FormThemHoaDon.DataSource = null;
            }


        }

        private void dataGridView_FormThemHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtPhongID_FormThemHoaDon_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpNgayDen_FormThemHoaDon_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpNgayDi_FormThemHoaDon_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtDonGia_FormThemHoaDon_TextChanged(object sender, EventArgs e)
        {

        }

        public event EventHandler HoaDonAdded;

        private void btnXacNhan_FormThemHoaDon_Click(object sender, EventArgs e)
        {
            int datPhongID = int.Parse(txtDatPhongID_FormThemHoaDon.Text);
            if(IsHoaDonExists(datPhongID)) {

                MessageBox.Show("Hóa đơn cho đặt phòng này đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Lấy dữ liệu từ form
                
                int phongID = int.Parse(txtPhongID_FormThemHoaDon.Text);

                DateTime ngayLap = DateTime.Now;
                DateTime ngayDen = dtpNgayDen_FormThemHoaDon.Value;
                DateTime ngayDi = dtpNgayDi_FormThemHoaDon.Value;

                decimal gia = decimal.Parse(txtDonGia_FormThemHoaDon.Text);
                decimal tienPhong = decimal.Parse(txtTienPhong_FormThemHoaDon.Text);

                int soLuongDV = string.IsNullOrEmpty(txtSoLuongDichVu_FormThemHoaDon.Text) ? 0 : int.Parse(txtSoLuongDichVu_FormThemHoaDon.Text);
                decimal tienDV = string.IsNullOrEmpty(txtTienDichVu_FormThemHoaDon.Text) ? 0 : decimal.Parse(txtTienDichVu_FormThemHoaDon.Text);

                string tinhTrangTT = "Chưa thanh toán";

                // Tạo truy vấn INSERT
                string insertQuery = @"
            INSERT INTO HoaDonTongHop (
                NGAYLAP, DATPHONGID, PHONGID, NGAYDEN, NGAYDI, GIA, TIENPHONG, 
                SOLUONGDICHVU, TIENDICHVU, TINHTRANGTHANHTOAN
            )
            VALUES (
                @NgayLap, @DatPhongID, @PhongID, @NgayDen, @NgayDi, @Gia, @TienPhong,
                @SoLuongDV, @TienDV, @TinhTrangTT
            )";

                SqlParameter[] parameters = new SqlParameter[]
                {
            new SqlParameter("@NgayLap", ngayLap),
            new SqlParameter("@DatPhongID", datPhongID),
            new SqlParameter("@PhongID", phongID),
            new SqlParameter("@NgayDen", ngayDen),
            new SqlParameter("@NgayDi", ngayDi),
            new SqlParameter("@Gia", gia),
            new SqlParameter("@TienPhong", tienPhong),
            new SqlParameter("@SoLuongDV", soLuongDV),
            new SqlParameter("@TienDV", tienDV),
            new SqlParameter("@TinhTrangTT", tinhTrangTT)
                };

                bool rowsAffected = dbHelper.ExecuteQuery(insertQuery, parameters);

                if (rowsAffected)
                {
                    HoaDonAdded?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show("Thêm hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thêm hóa đơn thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool IsHoaDonExists(int datPhongId)
        {
            // Kiểm tra DatPhongID đã có trong bảng HoaDonTongHop chưa
            string queryHoaDonCheck = "SELECT * FROM HoaDonTongHop WHERE DATPHONGID = @DatPhongID";
            SqlParameter[] paramHoaDonCheck = new SqlParameter[]
            {
                new SqlParameter("@DatPhongID", datPhongId)
            };

            DataTable hoaDonResult = dbHelper.GetData(queryHoaDonCheck, paramHoaDonCheck);

            if (hoaDonResult != null && hoaDonResult.Rows.Count > 0)
            {
                return true;
            }else { return false; }
            
        }
    }
}
