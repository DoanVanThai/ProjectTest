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
    }
}
