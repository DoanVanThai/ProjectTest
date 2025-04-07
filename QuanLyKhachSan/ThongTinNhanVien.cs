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
    public partial class ThongTinNhanVien: Form
    {
        private string chucvu;
        public ThongTinNhanVien(int ma, string hoten, DateTime ngaysinh, string gioitinh, string cccd, string sdt, string email, DateTime ngayvaolam, string chucvu, string luong)
        {
            InitializeComponent();
            txt_manv.Text = ma.ToString(); // Chuyển đổi mã thành chuỗi
            txt_hoten.Text = hoten;
            dt_ngaysinh.Value = ngaysinh;
            cbb_gioitinh.Text = gioitinh;
            txt_cccd.Text = cccd;
            txt_sdt.Text = sdt;
            txt_email.Text = email;
            dt_ngayvaolam.Value = ngayvaolam;
            this.chucvu = chucvu;
            txt_luong.Text = luong;

        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            int ma = int.Parse(txt_manv.Text.Trim());
            String hoten = txt_hoten.Text.Trim();
            DateTime ngaysinh = dt_ngaysinh.Value;
            String gioitinh = cbb_gioitinh.SelectedItem.ToString();
            String cccd = txt_cccd.Text.Trim();
            String sdt = txt_sdt.Text.Trim();
            String email = txt_email.Text.Trim();
            DateTime ngayvaolam = dt_ngayvaolam.Value;
            String chucvu = cbb_chucvu.SelectedValue.ToString();
            String luong = txt_luong.Text.Trim();
            if (string.IsNullOrWhiteSpace(hoten) ||
                 string.IsNullOrWhiteSpace(cccd) ||
                 string.IsNullOrWhiteSpace(sdt) ||
                 string.IsNullOrWhiteSpace(chucvu) ||
                 string.IsNullOrWhiteSpace(luong) ||
                 string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin nhân viên!", "THÔNG BÁO");
                return;
            }
            if (cbb_gioitinh.SelectedItem == null)
                gioitinh = "";
            else
                gioitinh = cbb_gioitinh.SelectedItem.ToString();
            // Kiểm tra số lượng ký tự đã nhập
            if (txt_cccd.Text.Length != 12)
            {
                MessageBox.Show("CCCD chỉ chứa 12 chữ số", "THÔNG BÁO");
                return;
            }
            if (txt_sdt.Text.Length != 10)
            {
                MessageBox.Show("SDT phải chứa 10 chữ số", "THÔNG BÁO");
                return;
            }
            if (!email.EndsWith("@gmail.com") ||
                    email.Length < 11 ||
                    !char.IsLetter(email[0]) ||
                    email.All(c => char.IsLetterOrDigit(c) || c == '.' || c == '_'))
            {
                MessageBox.Show("Vui lòng nhập email hợp lệ!");
                return;
            }
            if (classTT.con.State == ConnectionState.Closed)
                classTT.con.Open();
            string sql = "UPDATE NhanVien SET hoten=@ten, ngaysinh= @ns, gioitinh=@gt, SOCCCD=@cccd, SODIENTHOAI=@sdt, " +
                " EMAIL=@email, CHUCVUID=@chucvu, NGAYVAOLAM= @nvl, LUONG=@luong WHERE NHANVIENID=@id ";
            SqlCommand cmd = new SqlCommand(sql, classTT.con);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = ma;
            cmd.Parameters.Add("@ten", SqlDbType.NVarChar, 100).Value = hoten;
            cmd.Parameters.Add("@ns", SqlDbType.Date).Value = ngaysinh;
            cmd.Parameters.Add("@gt", SqlDbType.NVarChar, 10).Value = gioitinh;
            cmd.Parameters.Add("@cccd", SqlDbType.VarChar, 12).Value = cccd;
            cmd.Parameters.Add("@sdt", SqlDbType.VarChar, 10).Value = sdt;
            cmd.Parameters.Add("@email", SqlDbType.NVarChar, 100).Value = email;
            cmd.Parameters.Add("@chucvu", SqlDbType.NVarChar, 100).Value = chucvu;
            cmd.Parameters.Add("@nvl", SqlDbType.Date).Value = ngayvaolam;
            cmd.Parameters.Add("@luong", SqlDbType.Decimal).Value = luong;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Cập nhật thông tin nhân viên thành công", "THÔNG BÁO");
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có chắc chắn muốn xoá nhân viên?", "THÔNG BÁO", MessageBoxButtons.OKCancel);

            if (kq == DialogResult.OK)
            {
                string ma = txt_manv.Text.Trim();

                if (classTT.con.State == ConnectionState.Closed)
                    classTT.con.Open();

                string sql = "DELETE FROM NhanVien WHERE NHANVIENID = @id";
                SqlCommand cmd = new SqlCommand(sql, classTT.con);
                cmd.Parameters.Add("@id", SqlDbType.VarChar, 10).Value = ma;
                cmd.ExecuteNonQuery();
                classTT.con.Close();
                MessageBox.Show("Đã xóa thành công!", "THÔNG BÁO");
            }
            else
            {
                return;
            }
        }

        private void btn_quaylai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ktra_sodienthoai(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra nếu người dùng nhấn phím không phải là số
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ngăn không cho nhập ký tự không phải số
                MessageBox.Show("SDT chỉ chứa chữ số", "THÔNG BÁO");
            }

            // Kiểm tra số lượng ký tự đã nhập
            if (txt_sdt.Text.Length >= 10 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ngăn không cho nhập thêm ký tự nếu đã đủ 10 số
                MessageBox.Show("SDT chỉ chứa 10 chữ số", "THÔNG BÁO");
            }
        }

        private void luong_change(object sender, EventArgs e)
        {
            if (cbb_chucvu.SelectedItem != null)
            {
                int machucvu = cbb_chucvu.SelectedIndex;
                if (classTT.con.State == ConnectionState.Closed)
                    classTT.con.Open();
                string query = "SELECT LUONG FROM ChucVu WHERE ChucVuID= @Machucvu";
                SqlCommand cmd = new SqlCommand(query, classTT.con);
                cmd.Parameters.AddWithValue("@Machucvu", machucvu);
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    txt_luong.Text = result.ToString();
                }
                else
                {
                    txt_luong.Text = "0";
                }
                cmd.Dispose();
                classTT.con.Close();
            }
        }

        private void ktra_socccd(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra nếu người dùng nhấn phím không phải là số
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ngăn không cho nhập ký tự không phải số
                MessageBox.Show("CCCD chỉ chứa chữ số", "THÔNG BÁO");
            }
        }

        private void ThongTinNhanVien_Load(object sender, EventArgs e)
        {
            txt_manv.Enabled = true;
            classTT.load_chucvu(cbb_chucvu, null, "CHUCVUID", "TENCHUCVU");
            cbb_chucvu.SelectedValue = chucvu;
        }
    }
}
