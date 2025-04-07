
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace QuanLyKhachSan
{
    public partial class QuanLyPhong : Form
    {
        public QuanLyPhong()
        {
            InitializeComponent();
            this.Load += QuanLyPhong_Load;
            this.tablePhong.CellDoubleClick += TablePhong_CellDoubleClick;
            this.btnsua.Click += btnsua_Click;
        }



        private void QuanLyPhong_Load(object sender, EventArgs e)
        {
            LoadDanhSachPhong();

            try
            {
                using (SqlConnection conn = connectDB.GetConnection())
                {
                    // Xóa dữ liệu cũ trước khi load lại để tránh trùng lặp
                    ccbtimkiemtang.Items.Clear();
                    cbbtimkiemtinhtrang.Items.Clear();
                    timkiemtheoloaiphong.Items.Clear();

                    // Load tầng
                    SqlCommand cmdTang = new SqlCommand("SELECT TENTANG FROM Tang", conn);
                    SqlDataReader readerTang = cmdTang.ExecuteReader();
                    while (readerTang.Read())
                    {
                        ccbtimkiemtang.Items.Add(readerTang["TENTANG"].ToString());
                    }
                    readerTang.Close();

                    // Load loại phòng
                    SqlCommand cmdLoaiPhong = new SqlCommand("SELECT TENLOAIPHONG FROM LoaiPhong", conn);
                    SqlDataReader readerLoaiPhong = cmdLoaiPhong.ExecuteReader();
                    while (readerLoaiPhong.Read())
                    {
                        timkiemtheoloaiphong.Items.Add(readerLoaiPhong["TENLOAIPHONG"].ToString());
                    }
                    readerLoaiPhong.Close();

                    // Load tình trạng
                    cbbtimkiemtinhtrang.Items.Add("Trống");
                    cbbtimkiemtinhtrang.Items.Add("Đã đặt");
                    cbbtimkiemtinhtrang.Items.Add("Đã nhận phòng");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu tìm kiếm: " + ex.Message);
            }
        }



        private void LoadDanhSachPhong()
        {
            try
            {
                using (SqlConnection conn = connectDB.GetConnection())
                {
                    string query = @"
SELECT 
    p.PHONGID, 
    p.SOPHONG, 
    lp.TENLOAIPHONG, 
    p.GIA, 
    t.TENTANG, 
    p.TINHTRANG, 
    p.DIENTICH, 
    p.SONGUOITOIDA, 
    p.TRANGBI
FROM 
    Phong p
JOIN 
    LoaiPhong lp ON p.LOAIPHONGID = lp.LOAIPHONGID
JOIN 
    Tang t ON p.TANGID = t.TANGID
";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    tablePhong.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu phòng: " + ex.Message);
            }
        }

        private void TablePhong_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int phongId = Convert.ToInt32(tablePhong.Rows[e.RowIndex].Cells["PHONGID"].Value);
                DialogSuaPhong dialog = new DialogSuaPhong();
                dialog.PhongIdCanSua = phongId;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    LoadDanhSachPhong();
                }
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            DialogThemPhong dialog = new DialogThemPhong();
            dialog.ShowDialog();
            LoadDanhSachPhong();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (tablePhong.SelectedRows.Count > 0)
            {
                int phongId = Convert.ToInt32(tablePhong.SelectedRows[0].Cells["PHONGID"].Value);
                DialogSuaPhong dialog = new DialogSuaPhong();
                dialog.PhongIdCanSua = phongId;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    LoadDanhSachPhong();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một phòng để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            // Chưa dùng tới
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Chưa dùng tới
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (tablePhong.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa phòng này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    int phongId = Convert.ToInt32(tablePhong.SelectedRows[0].Cells["PHONGID"].Value);

                    try
                    {
                        using (SqlConnection conn = connectDB.GetConnection())
                        {
                            string query = "DELETE FROM Phong WHERE PHONGID = @ID";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.Parameters.AddWithValue("@ID", phongId);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Xóa phòng thành công!");
                            LoadDanhSachPhong();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xóa phòng: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một phòng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

      

        private void ccbtimkiemtang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }  

        private void cbbtimkiemtinhtrang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string tang = ccbtimkiemtang.SelectedItem?.ToString();
            string tinhTrang = cbbtimkiemtinhtrang.SelectedItem?.ToString();
            string loaiPhong = timkiemtheoloaiphong.SelectedItem?.ToString();
            string keyword = txttimkiem.Text?.Trim();

            try
            {
                using (SqlConnection conn = connectDB.GetConnection())
                {
                    string query = @"
                SELECT 
                    p.PHONGID, 
                    p.SOPHONG, 
                    lp.TENLOAIPHONG, 
                    p.GIA, 
                    t.TENTANG, 
                    p.TINHTRANG, 
                    p.DIENTICH, 
                    p.SONGUOITOIDA, 
                    p.TRANGBI
                FROM 
                    Phong p
                JOIN LoaiPhong lp ON p.LOAIPHONGID = lp.LOAIPHONGID
                JOIN Tang t ON p.TANGID = t.TANGID
                WHERE 1=1";

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;

                    if (!string.IsNullOrEmpty(tang))
                    {
                        query += " AND t.TENTANG = @Tang";
                        cmd.Parameters.AddWithValue("@Tang", tang);
                    }

                    if (!string.IsNullOrEmpty(tinhTrang))
                    {
                        query += " AND p.TINHTRANG = @TinhTrang";
                        cmd.Parameters.AddWithValue("@TinhTrang", tinhTrang);
                    }

                    if (!string.IsNullOrEmpty(loaiPhong))
                    {
                        query += " AND lp.TENLOAIPHONG = @LoaiPhong";
                        cmd.Parameters.AddWithValue("@LoaiPhong", loaiPhong);
                    }

                    if (!string.IsNullOrEmpty(keyword))
                    {
                        query += @" AND (
                    p.SOPHONG LIKE @Keyword OR 
                    lp.TENLOAIPHONG LIKE @Keyword OR 
                    p.TINHTRANG LIKE @Keyword OR 
                    t.TENTANG LIKE @Keyword OR 
                    p.TRANGBI LIKE @Keyword
                )";
                        cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");
                    }

                    cmd.CommandText = query;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    tablePhong.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message);
            }
        }


        private void btnreset_Click(object sender, EventArgs e)
        {
            ccbtimkiemtang.SelectedIndex = -1;
            cbbtimkiemtinhtrang.SelectedIndex = -1;
            timkiemtheoloaiphong.SelectedIndex = -1;
            txttimkiem.Clear();
            LoadDanhSachPhong();
        }


        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void timkiemtheoloaiphong_SelectedIndexChanged(object sender, EventArgs e)
        {

        }







        private void ExportToExcel(DataTable dataTable, string sheetName)
        {
            try
            {
                var excelApp = new Excel.Application();
                if (excelApp == null)
                {
                    MessageBox.Show("Không thể khởi tạo Excel. Hãy chắc chắn rằng Excel đã được cài đặt.");
                    return;
                }

                excelApp.Visible = true;
                Excel.Workbook workbook = excelApp.Workbooks.Add(Type.Missing);
                Excel.Worksheet worksheet = workbook.ActiveSheet;
                worksheet.Name = sheetName;

                // Ghi tiêu đề
                for (int i = 0; i < dataTable.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1] = dataTable.Columns[i].ColumnName;
                }

                // Ghi dữ liệu
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    for (int j = 0; j < dataTable.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dataTable.Rows[i][j].ToString();
                    }
                }

                // Autofit columns
                worksheet.Columns.AutoFit();
                MessageBox.Show("Xuất Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xuất Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }








        private void btnxuat_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)tablePhong.DataSource;
            if (dt != null && dt.Rows.Count > 0)
            {
                ExportToExcel(dt, "DANH SÁCH PHÒNG");
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để xuất.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private DataTable ReadExcelFile(string filePath)
        {
            DataTable dt = new DataTable();
            try
            {
                // Khởi tạo ứng dụng Excel
                var excelApp = new Excel.Application();
                if (excelApp == null)
                {
                    MessageBox.Show("Không thể khởi tạo Excel. Hãy chắc chắn rằng Excel đã được cài đặt.");
                    return null;
                }

                // Mở workbook và lấy worksheet đầu tiên
                Excel.Workbook workbook = excelApp.Workbooks.Open(filePath);
                Excel._Worksheet worksheet = workbook.Sheets[1];
                Excel.Range range = worksheet.UsedRange;

                // Đọc header (tên cột)
                int colCount = range.Columns.Count;
                for (int i = 1; i <= colCount; i++)
                {
                    string columnName = (range.Cells[1, i] as Excel.Range).Text.ToString();
                    dt.Columns.Add(columnName); // Thêm cột vào DataTable
                }

                // Đọc dữ liệu
                int rowCount = range.Rows.Count;
                for (int i = 2; i <= rowCount; i++) // Bắt đầu từ dòng 2 để bỏ qua header
                {
                    DataRow row = dt.NewRow();
                    for (int j = 1; j <= colCount; j++)
                    {
                        row[j - 1] = (range.Cells[i, j] as Excel.Range).Text.ToString(); // Ghi giá trị vào DataRow
                    }
                    dt.Rows.Add(row); // Thêm row vào DataTable
                }

                workbook.Close(false); // Đóng workbook
                excelApp.Quit(); // Thoát Excel

                return dt; // Trả về DataTable
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đọc file Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }







        private int GetIdFromName(SqlConnection conn, string table, string columnName, string idColumn, string value)
        {
            SqlCommand cmd = new SqlCommand($"SELECT {idColumn} FROM {table} WHERE {columnName} = @value", conn);
            cmd.Parameters.AddWithValue("@value", value);
            object result = cmd.ExecuteScalar();
            return result != null ? Convert.ToInt32(result) : -1;
        }


        private void btnnhap_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Files|*.xlsx;*.xls";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                DataTable excelData = ReadExcelFile(filePath);

                if (excelData != null)
                {
                    try
                    {
                        using (SqlConnection conn = connectDB.GetConnection())
                        {
                            foreach (DataRow row in excelData.Rows)
                            {
                                string tenLoaiPhong = row["TENLOAIPHONG"].ToString().Trim();
                                string tenTang = row["TENTANG"].ToString().Trim();

                                // Truy vấn lấy ID tương ứng
                                int loaiPhongId = GetIdFromName(conn, "LoaiPhong", "TENLOAIPHONG", "LOAIPHONGID", tenLoaiPhong);
                                int tangId = GetIdFromName(conn, "Tang", "TENTANG", "TANGID", tenTang);

                                if (loaiPhongId == -1 || tangId == -1)
                                {
                                    MessageBox.Show($"Không tìm thấy ID cho loại phòng: {tenLoaiPhong} hoặc tầng: {tenTang}");
                                    continue;
                                }

                                string query = @"
                            INSERT INTO Phong (SOPHONG, LOAIPHONGID, GIA, TANGID, TINHTRANG, DIENTICH, SONGUOITOIDA, TRANGBI)
                            VALUES (@SOPHONG, @LOAIPHONGID, @GIA, @TANGID, @TINHTRANG, @DIENTICH, @SONGUOITOIDA, @TRANGBI)";

                                SqlCommand cmd = new SqlCommand(query, conn);
                                cmd.Parameters.AddWithValue("@SOPHONG", row["SOPHONG"]);
                                cmd.Parameters.AddWithValue("@LOAIPHONGID", loaiPhongId);
                                cmd.Parameters.AddWithValue("@GIA", row["GIA"]);
                                cmd.Parameters.AddWithValue("@TANGID", tangId);
                                cmd.Parameters.AddWithValue("@TINHTRANG", row["TINHTRANG"]);
                                cmd.Parameters.AddWithValue("@DIENTICH", row["DIENTICH"]);
                                cmd.Parameters.AddWithValue("@SONGUOITOIDA", row["SONGUOITOIDA"]);
                                cmd.Parameters.AddWithValue("@TRANGBI", row["TRANGBI"]);

                                cmd.ExecuteNonQuery();
                            }
                        }

                        MessageBox.Show("✅ Nhập dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDanhSachPhong();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("❌ Lỗi khi nhập dữ liệu: " + ex.Message);
                    }
                }
            }
        }

        private void btnchangeview_Click(object sender, EventArgs e)
        {

        }
    }
}
