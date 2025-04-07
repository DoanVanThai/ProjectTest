using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    class connectDB
    {
<<<<<<< HEAD
        //ket noi cua DOAN VAN THAI : SFWEFSDC34\SQLEXPRESS
        private static string connectionString = "Server=SFWEFSDC34\\SQLEXPRESS;Database=QUANLYKHACHSAN;Integrated Security=True;";

        //ket noi cua hai vang :
        //private static string connectionString = @"Data Source=DEVVG\\SQLEXPRESS;Initial Catalog=QUANLYKHACHSAN;Integrated Security=True";
        
=======
        //ket noi cua DOAN VAN THAI :
        //private static string connectionString = "Server=DEVVG\\SQLEXPRESS;Database=QUANLYKHACHSAN;Integrated Security=True;";

        //ket noi cua hai vang :
        //private stat1ic string connectionString = @"Data Source=DEVVG\\SQLEXPRESS;Initial Catalog=QUANLYKHACHSAN;Integrated Security=True";
        private static string connectionString = "Data Source=LAPTOP-HCDG5L88;Initial Catalog=QUANLYKHACHSAN;Integrated Security=True;";



>>>>>>> 6fa0bc3 (Lưu lại để pull)
        public static SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                throw new Exception("Kết nối cơ sở dữ liệu thất bại: " + ex.Message);
            }
            return conn;
        }
    }
}
