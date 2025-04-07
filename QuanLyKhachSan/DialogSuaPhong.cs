using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class DialogSuaPhong : Form
    {
        public int PhongIdCanSua { get; set; }

        public DialogSuaPhong()
        {
            InitializeComponent();
            this.Load += DialogSuaPhong_Load;
            //btnsua.Click += btnsua_Click;
            btncancel.Click += (s, e) => this.Close(); // Nút hủy
        }

        private void DialogSuaPhong_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = connectDB.GetConnection())
                {
                    // Load Loại phòng
                    SqlDataAdapter daLoaiPhong = new SqlDataAdapter("SELECT LOAIPHONGID, TENLOAIPHONG FROM LoaiPhong", conn);
                    DataTable dtLoaiPhong = new DataTable();
                    daLoaiPhong.Fill(dtLoaiPhong);
                    cbbloaiphong.DataSource = dtLoaiPhong;
                    cbbloaiphong.DisplayMember = "TENLOAIPHONG";
                    cbbloaiphong.ValueMember = "LOAIPHONGID";

                    // Load Tầng
                    SqlDataAdapter daTang = new SqlDataAdapter("SELECT TANGID, TENTANG FROM Tang", conn);
                    DataTable dtTang = new DataTable();
                    daTang.Fill(dtTang);
                    cbbtang.DataSource = dtTang;
                    cbbtang.DisplayMember = "TENTANG";
                    cbbtang.ValueMember = "TANGID";

                    // Load tình trạng
                    cbbtinhtrang.Items.Clear();
                    cbbtinhtrang.Items.Add("Trống");
                    cbbtinhtrang.Items.Add("Đã đặt");
                    cbbtinhtrang.Items.Add("Đã nhận phòng");

                    // Load thông tin phòng
                    string query = "SELECT * FROM Phong WHERE PHONGID = @ID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ID", PhongIdCanSua);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        txtsophong.Text = reader["SOPHONG"].ToString();
                        txtgia.Text = reader["GIA"].ToString();
                        txtdientich.Text = reader["DIENTICH"].ToString();
                        txttrangbi.Text = reader["TRANGBI"].ToString();
                        nummax.Value = Convert.ToInt32(reader["SONGUOITOIDA"]);
                        cbbloaiphong.SelectedValue = reader["LOAIPHONGID"];
                        cbbtang.SelectedValue = reader["TANGID"];
                        cbbtinhtrang.SelectedItem = reader["TINHTRANG"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load dữ liệu phòng: " + ex.Message);
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            // Kiểm tra rỗng tất cả trường
            if (string.IsNullOrWhiteSpace(txtsophong.Text) ||
                string.IsNullOrWhiteSpace(txtgia.Text) ||
                string.IsNullOrWhiteSpace(txtdientich.Text) ||
                string.IsNullOrWhiteSpace(txttrangbi.Text) ||
                cbbloaiphong.SelectedIndex == -1 ||
                cbbtang.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(cbbtinhtrang.Text))
            {
                MessageBox.Show("❗ Vui lòng nhập đầy đủ tất cả thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Số phòng phải là số nguyên dương
            if (!int.TryParse(txtsophong.Text, out int soPhongSo) || soPhongSo <= 0)
            {
                MessageBox.Show("❌ Số phòng phải là số nguyên dương!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Giá phải là số
            if (!decimal.TryParse(txtgia.Text, out decimal gia))
            {
                MessageBox.Show("❌ Giá phòng phải là số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Diện tích phải là số
            if (!decimal.TryParse(txtdientich.Text, out decimal dientich))
            {
                MessageBox.Show("❌ Diện tích phải là số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Số người tối đa phải lớn hơn 0
            if (nummax.Value < 1)
            {
                MessageBox.Show("❌ Số người tối đa phải từ 1 trở lên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = connectDB.GetConnection())
                {
                    // Kiểm tra trùng số phòng
                    SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM Phong WHERE SOPHONG = @sophong", conn);
                    checkCmd.Parameters.AddWithValue("@sophong", txtsophong.Text.Trim());
                    int count = (int)checkCmd.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("❌ Số phòng này đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Câu lệnh thêm
                    string query = "INSERT INTO Phong (SOPHONG, LOAIPHONGID, GIA, TANGID, TINHTRANG, DIENTICH, SONGUOITOIDA, TRANGBI) " +
                                   "VALUES (@SoPhong, @LoaiPhongID, @Gia, @TangID, @TinhTrang, @DienTich, @SoNguoiToiDa, @TrangBi)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@SoPhong", txtsophong.Text.Trim());
                    cmd.Parameters.AddWithValue("@LoaiPhongID", cbbloaiphong.SelectedValue);
                    cmd.Parameters.AddWithValue("@Gia", gia);
                    cmd.Parameters.AddWithValue("@TangID", cbbtang.SelectedValue);
                    cmd.Parameters.AddWithValue("@TinhTrang", cbbtinhtrang.Text);
                    cmd.Parameters.AddWithValue("@DienTich", dientich);
                    cmd.Parameters.AddWithValue("@SoNguoiToiDa", (int)nummax.Value);
                    cmd.Parameters.AddWithValue("@TrangBi", txttrangbi.Text.Trim());

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("✅ Thêm phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Lỗi thêm phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtsophong_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
