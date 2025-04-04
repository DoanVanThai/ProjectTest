using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan
{
    class connectDB
    {
        private static string connectionString = @"Data Source=DESKTOP-K31BK4E;Initial Catalog=QUANLYKHACHSANBACKUP;Integrated Security=True";

        //ket noi cua hai vang :
        //private static string connectionString = @"Data Source=DEVVG\\SQLEXPRESS;Initial Catalog=QUANLYKHACHSAN;Integrated Security=True";


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
