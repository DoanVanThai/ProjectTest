using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    class classTT
    {
        public static SqlConnection con = new SqlConnection("Data Source = SFWEFSDC34\\SQLEXPRESS; Initial Catalog = QUANLYKHACHSAN; Integrated Security = True");
        public static void load_nhanvien(DataGridView tble_nhanvien)
        {

            if (con.State == ConnectionState.Closed)
                con.Open();
            string query = "SELECT nv.NHANVIENID, nv.HOTEN, nv.NGAYSINH, nv.GIOITINH, nv.SOCCCD, " +
                "nv.SODIENTHOAI, nv.EMAIL, cv.TENCHUCVU, nv.NGAYVAOLAM, nv.LUONG, nv.CHUCVUID " +
                "FROM  NhanVien nv LEFT JOIN ChucVu cv ON nv.CHUCVUID = cv.CHUCVUID";
            SqlCommand cmd = new SqlCommand(query, con);
            //lấy dữ liệu từ cmd
            SqlDataAdapter ds = new SqlDataAdapter();
            ds.SelectCommand = cmd;
            //lấy dữ liêu từ ds
            DataTable tb = new DataTable();
            ds.Fill(tb);
            cmd.Dispose();
            con.Close();
            //hiển thị lên datagridview
            tble_nhanvien.DataSource = tb;
            tble_nhanvien.Refresh();

        }
        public static void load_chucvu(ComboBox cbb_chucvu, ComboBox cbb_timchucvu, string cot1, string cot2)
        {
            //b1 kêt nối
            if (con.State == ConnectionState.Closed)
                con.Open();
            //b2 tạo đối tượng command
            string sql = "SELECT * FROM ChucVu";
            SqlCommand cmd = new SqlCommand(sql, con);
            //b3: tạo đối tượng datadapter để lấy kq từ cmd 
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            //tạo đối tượng datatable để lấy dl từ da
            DataTable tb = new DataTable();
            da.Fill(tb);
            cmd.Dispose();// giải phóng cmd 
            con.Close();// ngắt kết nối
            //bổ sung thêm 1 dòng 
            DataRow r = tb.NewRow();
            r[cot1] = 0;
            r[cot2] = "--Chọn chức vụ--";
            tb.Rows.InsertAt(r, 0);
            //b5: đổ dl từ tb vào cbb
            cbb_chucvu.DataSource = tb;
            cbb_chucvu.DisplayMember = "TENCHUCVU";// hiển thị lên cbb
            cbb_chucvu.ValueMember = "CHUCVUID";// giá trị thực mà người dùng lấy 
            cbb_chucvu.Refresh();
            // đổ dl từ tb vào cbb tìm kiếm 
            if (cbb_timchucvu != null)
            {
                cbb_timchucvu.DataSource = tb;
                cbb_timchucvu.DisplayMember = "TENCHUCVU";
                cbb_timchucvu.ValueMember = "CHUCVUID";
                cbb_timchucvu.Refresh();
            }
        }
    }
}
