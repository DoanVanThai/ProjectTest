////using System;
////using System.Data;
////using System.Data.SqlClient;
////using System.Drawing;
////using System.Windows.Forms;

////namespace QuanLyKhachSan
////{
////    public partial class DatPhong : Form
////    {
////        private string connectionString = "Data Source=.;Initial Catalog=QUANLYKHACHSAN;Integrated Security=True";

////        public DatPhong()
////        {
////            InitializeComponent();
////            this.Load += DatPhong_Load;
////        }

////        private void DatPhong_Load(object sender, EventArgs e)
////        {
////            LoadDanhSachPhong();
////        }

////        private void LoadDanhSachPhong()
////        {
////            flpDanhSachPhong.Controls.Clear();

////            using (SqlConnection conn = new SqlConnection(connectionString))
////            {
////                string query = @"
////                    SELECT 
////                        p.PHONGID, p.SOPHONG, lp.TENLOAIPHONG, p.GIA, t.TENTANG,
////                        p.TINHTRANG, p.DIENTICH, p.TRANGBI
////                    FROM Phong p
////                    JOIN LoaiPhong lp ON p.LOAIPHONGID = lp.LOAIPHONGID
////                    JOIN Tang t ON p.TANGID = t.TANGID";

////                SqlDataAdapter da = new SqlDataAdapter(query, conn);
////                DataTable dt = new DataTable();
////                da.Fill(dt);

////                foreach (DataRow row in dt.Rows)
////                {
////                    AddPhongCard(row);
////                }
////            }
////        }

////        private void AddPhongCard(DataRow data)
////        {
////            var groupBox = new GroupBox();
////            groupBox.Width = 250;
////            groupBox.Height = 200;
////            groupBox.Margin = new Padding(10);
////            groupBox.Text = $"Phòng {data["SOPHONG"]}";

////            var lbLoai = new Label() { Text = "Loại: " + data["TENLOAIPHONG"], AutoSize = true, Location = new Point(10, 20) };
////            var lbGia = new Label() { Text = "Giá: " + Convert.ToDecimal(data["GIA"]).ToString("N0") + " VNĐ", AutoSize = true, Location = new Point(10, 40) };
////            var lbTang = new Label() { Text = "Tầng: " + data["TENTANG"], AutoSize = true, Location = new Point(10, 60) };
////            var lbTinhTrang = new Label() { Text = "Tình trạng: " + data["TINHTRANG"], AutoSize = true, Location = new Point(10, 80) };
////            var lbTrangBi = new Label() { Text = "Trang bị: " + data["TRANGBI"], AutoSize = true, Location = new Point(10, 100) };

////            var btnDat = new Button() { Width = 100, Height = 30, Location = new Point(10, 130) };

////            if (data["TINHTRANG"].ToString().Trim() == "Trống")
////            {
////                btnDat.Text = "Đặt phòng";
////                btnDat.BackColor = Color.LightGreen;
////                btnDat.Enabled = true;
////                btnDat.Click += (s, e) =>
////                {
////                    MessageBox.Show($"Bạn đã chọn đặt phòng {data["SOPHONG"]} (ID: {data["PHONGID"]})");
////                    int phongId = Convert.ToInt32(data["PHONGID"]);
////                    string soPhong = data["SOPHONG"].ToString();
////                    string loaiPhong = data["TENLOAIPHONG"].ToString();
////                    decimal gia = Convert.ToDecimal(data["GIA"]);

////                    var form = new DatPhongDetails(phongId, soPhong, loaiPhong, gia);
////                    if (form.ShowDialog() == DialogResult.OK)
////                    {
////                        LoadDanhSachPhong(); // cập nhật lại danh sách phòng
////                    }

////                };
////            }
////            else
////            {
////                btnDat.Text = "Không khả dụng";
////                btnDat.BackColor = Color.LightGray;
////                btnDat.Enabled = false;
////            }

////            groupBox.Controls.Add(lbLoai);
////            groupBox.Controls.Add(lbGia);
////            groupBox.Controls.Add(lbTang);
////            groupBox.Controls.Add(lbTinhTrang);
////            groupBox.Controls.Add(lbTrangBi);
////            groupBox.Controls.Add(btnDat);

////            flpDanhSachPhong.Controls.Add(groupBox);
////        }


////        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
////        {

////        }

////        private void flpDanhSachPhong_Paint(object sender, PaintEventArgs e)
////        {

////        }

////        private void timkiem_Click(object sender, EventArgs e)
////{
////    string keyword = txttimkiem.Text.Trim();
////    string tinhTrang = cbbtimkiemtinhtrang.SelectedItem?.ToString();

////    flpDanhSachPhong.Controls.Clear();

////    using (SqlConnection conn = new SqlConnection(connectionString))
////    {
////        string query = @"
////            SELECT 
////                p.PHONGID, p.SOPHONG, lp.TENLOAIPHONG, p.GIA, t.TENTANG,
////                p.TINHTRANG, p.DIENTICH, p.TRANGBI
////            FROM Phong p
////            JOIN LoaiPhong lp ON p.LOAIPHONGID = lp.LOAIPHONGID
////            JOIN Tang t ON p.TANGID = t.TANGID
////            WHERE 1=1";

////        SqlCommand cmd = new SqlCommand();
////        cmd.Connection = conn;

////        if (!string.IsNullOrEmpty(keyword))
////        {
////            query += @"
////                AND (
////                    p.SOPHONG LIKE @kw OR
////                    lp.TENLOAIPHONG LIKE @kw OR
////                    t.TENTANG LIKE @kw OR
////                    p.TINHTRANG LIKE @kw OR
////                    p.TRANGBI LIKE @kw OR
////                    CAST(p.GIA AS NVARCHAR) LIKE @kw OR
////                    CAST(p.DIENTICH AS NVARCHAR) LIKE @kw
////                )";
////            cmd.Parameters.AddWithValue("@kw", "%" + keyword + "%");
////        }

////        if (!string.IsNullOrEmpty(tinhTrang))
////        {
////            query += " AND p.TINHTRANG = @tt";
////            cmd.Parameters.AddWithValue("@tt", tinhTrang);
////        }

////        cmd.CommandText = query;

////        SqlDataAdapter da = new SqlDataAdapter(cmd);
////        DataTable dt = new DataTable();
////        da.Fill(dt);

////        foreach (DataRow row in dt.Rows)
////        {
////            AddPhongCard(row);
////        }

////        if (dt.Rows.Count == 0)
////        {
////            MessageBox.Show("Không tìm thấy phòng phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
////        }
////    }
////}


////        private void txttimkiem_TextChanged(object sender, EventArgs e)
////        {

////        }


////        private void cbbtimkiemtinhtrang_SelectedIndexChanged(object sender, EventArgs e)
////        {

////        }
////    }
////}


//using System;
//using System.Data;
//using System.Data.SqlClient;
//using System.Drawing;
//using System.Windows.Forms;

//namespace QuanLyKhachSan
//{
//    public partial class DatPhong : Form
//    {
//        private string connectionString = "Data Source=.;Initial Catalog=QUANLYKHACHSAN;Integrated Security=True";

//        public DatPhong()
//        {
//            InitializeComponent();
//            this.Load += DatPhong_Load;
//            this.timkiem.Click += timkiem_Click;
//            this.cbbtimkiemtinhtrang.SelectedIndexChanged += cbbtimkiemtinhtrang_SelectedIndexChanged;
//        }

//        private void DatPhong_Load(object sender, EventArgs e)
//        {
//            LoadDanhSachPhong();

//            // Đổ dữ liệu tình trạng vào combobox
//            cbbtimkiemtinhtrang.Items.Clear();
//            cbbtimkiemtinhtrang.Items.Add("Trống");
//            cbbtimkiemtinhtrang.Items.Add("Đã đặt");
//            cbbtimkiemtinhtrang.Items.Add("Đã nhận phòng");
//            cbbtimkiemtinhtrang.SelectedIndex = 0;
//        }

//        private void LoadDanhSachPhong()
//        {
//            flpDanhSachPhong.Controls.Clear();

//            using (SqlConnection conn = new SqlConnection(connectionString))
//            {
//                string query = @"
//                    SELECT 
//                        p.PHONGID, p.SOPHONG, lp.TENLOAIPHONG, p.GIA, t.TENTANG,
//                        p.TINHTRANG, p.DIENTICH, p.TRANGBI
//                    FROM Phong p
//                    JOIN LoaiPhong lp ON p.LOAIPHONGID = lp.LOAIPHONGID
//                    JOIN Tang t ON p.TANGID = t.TANGID";

//                SqlDataAdapter da = new SqlDataAdapter(query, conn);
//                DataTable dt = new DataTable();
//                da.Fill(dt);

//                foreach (DataRow row in dt.Rows)
//                {
//                    AddPhongCard(row);
//                }
//            }
//        }

//        private void AddPhongCard(DataRow data)
//        {
//            var groupBox = new GroupBox();
//            groupBox.Width = 250;
//            groupBox.Height = 200;
//            groupBox.Margin = new Padding(10);
//            groupBox.Text = $"Phòng {data["SOPHONG"]}";

//            var lbLoai = new Label() { Text = "Loại: " + data["TENLOAIPHONG"], AutoSize = true, Location = new Point(10, 20) };
//            var lbGia = new Label() { Text = "Giá: " + Convert.ToDecimal(data["GIA"]).ToString("N0") + " VNĐ", AutoSize = true, Location = new Point(10, 40) };
//            var lbTang = new Label() { Text = "Tầng: " + data["TENTANG"], AutoSize = true, Location = new Point(10, 60) };
//            var lbTinhTrang = new Label() { Text = "Tình trạng: " + data["TINHTRANG"], AutoSize = true, Location = new Point(10, 80) };
//            var lbTrangBi = new Label() { Text = "Trang bị: " + data["TRANGBI"], AutoSize = true, Location = new Point(10, 100) };

//            var btnDat = new Button() { Width = 100, Height = 30, Location = new Point(10, 130) };

//            if (data["TINHTRANG"].ToString().Trim() == "Trống")
//            {
//                btnDat.Text = "Đặt phòng";
//                btnDat.BackColor = Color.LightGreen;
//                btnDat.Enabled = true;
//                btnDat.Click += (s, e) =>
//                {
//                    MessageBox.Show($"Bạn đã chọn đặt phòng {data["SOPHONG"]} (ID: {data["PHONGID"]})");
//                    int phongId = Convert.ToInt32(data["PHONGID"]);
//                    string soPhong = data["SOPHONG"].ToString();
//                    string loaiPhong = data["TENLOAIPHONG"].ToString();
//                    decimal gia = Convert.ToDecimal(data["GIA"]);

//                    var form = new DatPhongDetails(phongId, soPhong, loaiPhong, gia);
//                    if (form.ShowDialog() == DialogResult.OK)
//                    {
//                        LoadDanhSachPhong();
//                    }
//                };
//            }
//            else
//            {
//                btnDat.Text = "Không khả dụng";
//                btnDat.BackColor = Color.LightGray;
//                btnDat.Enabled = false;
//            }

//            groupBox.Controls.Add(lbLoai);
//            groupBox.Controls.Add(lbGia);
//            groupBox.Controls.Add(lbTang);
//            groupBox.Controls.Add(lbTinhTrang);
//            groupBox.Controls.Add(lbTrangBi);
//            groupBox.Controls.Add(btnDat);

//        }

//        private void timkiem_Click(object sender, EventArgs e)
//        {
//            string keyword = txttimkiem.Text.Trim();
//            string tinhTrang = cbbtimkiemtinhtrang.SelectedItem?.ToString();

//            flpDanhSachPhong.Controls.Clear();

//            using (SqlConnection conn = new SqlConnection(connectionString))
//            {
//                string query = @"
//                    SELECT 
//                        p.PHONGID, p.SOPHONG, lp.TENLOAIPHONG, p.GIA, t.TENTANG,
//                        p.TINHTRANG, p.DIENTICH, p.TRANGBI
//                    FROM Phong p
//                    JOIN LoaiPhong lp ON p.LOAIPHONGID = lp.LOAIPHONGID
//                    JOIN Tang t ON p.TANGID = t.TANGID
//                    WHERE 1=1";

//                SqlCommand cmd = new SqlCommand();
//                cmd.Connection = conn;

//                if (!string.IsNullOrEmpty(keyword))
//                {
//                    query += @"
//                        AND (
//                            p.SOPHONG LIKE @kw OR
//                            lp.TENLOAIPHONG LIKE @kw OR
//                            t.TENTANG LIKE @kw OR
//                            p.TINHTRANG LIKE @kw OR
//                            p.TRANGBI LIKE @kw OR
//                            CAST(p.GIA AS NVARCHAR) LIKE @kw OR
//                            CAST(p.DIENTICH AS NVARCHAR) LIKE @kw
//                        )";
//                    cmd.Parameters.AddWithValue("@kw", "%" + keyword + "%");
//                }

//                if (!string.IsNullOrEmpty(tinhTrang))
//                {
//                    query += " AND p.TINHTRANG = @tt";
//                    cmd.Parameters.AddWithValue("@tt", tinhTrang);
//                }

//                cmd.CommandText = query;

//                SqlDataAdapter da = new SqlDataAdapter(cmd);
//                DataTable dt = new DataTable();
//                da.Fill(dt);

//                foreach (DataRow row in dt.Rows)
//                {
//                    AddPhongCard(row);
//                }

//                if (dt.Rows.Count == 0)
//                {
//                    MessageBox.Show("Không tìm thấy phòng phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
//                }
//            }
//        }

//        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

//        private void flpDanhSachPhong_Paint(object sender, PaintEventArgs e) { }

//        private void txttimkiem_TextChanged(object sender, EventArgs e) { }

//        private void cbbtimkiemtinhtrang_SelectedIndexChanged(object sender, EventArgs e) { }

//        private void btnreset_Click(object sender, EventArgs e)
//        {
//            txttimkiem.Clear();
//            cbbtimkiemtinhtrang.SelectedIndex = 0;
//            LoadDanhSachPhong();
//        }
//    }
//}