using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan.Library
{
    public class DatabaseHelper
    {
        private static DatabaseHelper instance;
        private string connectionString;
        private DatabaseHelper()
        {
            // Lấy chuỗi kết nối từ biến môi trường
            connectionString = Environment.GetEnvironmentVariable("DB_CONNECTION_STRING");
            if (string.IsNullOrEmpty(connectionString))
            {
                MessageBox.Show("Không tìm thấy chuỗi kết nối! Vui lòng thiết lập biến môi trường DB_CONNECTION_STRING.",
                                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new Exception("Chuỗi kết nối chưa được thiết lập.");
            }
        }
        public static DatabaseHelper Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DatabaseHelper();
                }
                return instance;
            }
        }
        public DataTable GetData(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        if (parameters != null)
                        {
                            command.Parameters.AddRange(parameters);
                        }
                        using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            dataAdapter.Fill(dataTable);
                            return dataTable;

                        }
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi SQL: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
        }
        public bool ExecuteQuery(string query, SqlParameter[] parameters)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddRange(parameters);
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Lỗi SQL: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }
    }
}
