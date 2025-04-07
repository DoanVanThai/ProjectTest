using QuanLyKhachSan.Library;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class DatDichVu : Form
    {
        public DatDichVu()
        {
            InitializeComponent();
            LoadDichVuData();
            cbbphong.Items.Add("---Select---");
            cbbphong.SelectedIndex = 0;
            LoadPhongData();
            LoadDataIntoGrvDVdaDat();
            txtsl.Text = "1"; // Set default quantity to 1
                              // Set the default selected index to the first item
        }

        private void LoadDataIntoGrvDVdaDat()
        {
            // Get the connection from connectDB class
            SqlConnection con = connectDB.GetConnection();

            // Make sure the connection is open
            if (con.State == ConnectionState.Closed)
                con.Open();

            // Define your query
            string query = @"
        SELECT 
            p.SOPHONG AS 'Tên phòng', 
            dv.TENDICHVU AS 'Tên dịch vụ', 
            ddv.GIA AS 'Đơn giá', 
            ddv.NGAYDAT AS 'Ngày đặt', 
            ddv.SOLUONG AS 'Số lượng'
        FROM 
            DatDichVu ddv
        JOIN 
            Phong p ON p.PHONGID = ddv.DATPHONGID
        JOIN 
            DichVu dv ON dv.DICHVUID = ddv.DICHVUID";

            // Create a SqlDataAdapter to execute the query
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con);

            // Create a DataTable to hold the data
            DataTable dataTable = new DataTable();

            // Fill the DataTable with data from the query
            dataAdapter.Fill(dataTable);

            // Bind the data to the grvDVdaDat DataGridView
            grvDVdaDat.DataSource = dataTable;

            // Set headers and widths for the columns of grvDVdaDat
            grvDVdaDat.Columns["Tên phòng"].HeaderText = "Tên phòng";
            grvDVdaDat.Columns["Tên dịch vụ"].HeaderText = "Tên dịch vụ";
            grvDVdaDat.Columns["Đơn giá"].HeaderText = "Đơn giá";
            grvDVdaDat.Columns["Ngày đặt"].HeaderText = "Ngày đặt";
            grvDVdaDat.Columns["Số lượng"].HeaderText = "Số lượng";

            // Adjust the widths of the columns
            grvDVdaDat.Columns["Tên phòng"].Width = 70;
            grvDVdaDat.Columns["Tên dịch vụ"].Width = 140;
            grvDVdaDat.Columns["Đơn giá"].Width = 90;
            grvDVdaDat.Columns["Ngày đặt"].Width = 90;
            grvDVdaDat.Columns["Số lượng"].Width = 70;

            // Close the connection
            con.Close();
        }


        // Method to load data from the DichVu table into the DataGridView
        private void LoadDichVuData()
        {
            // Get the connection from connectDB class
            SqlConnection con = connectDB.GetConnection();

            // Make sure the connection is open
            if (con.State == ConnectionState.Closed)
                con.Open();

            // Define the query to get all data from the DichVu table
            string query = "SELECT * FROM DichVu";

            // Create the SqlDataAdapter to execute the query
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con);

            // Create a DataTable to hold the fetched data
            DataTable dataTable = new DataTable();

            // Fill the DataTable with the data from the database
            dataAdapter.Fill(dataTable);

            // Check if data was fetched successfully
            if (dataTable.Rows.Count > 0)
            {
                // Bind the data to the grvSearchDV DataGridView
                grvSearchDV.DataSource = dataTable;

                // Modify the column headers and widths AFTER binding the data
                grvSearchDV.Columns["DICHVUID"].HeaderText = "ID";
                grvSearchDV.Columns["TENDICHVU"].HeaderText = "Tên dịch vụ";
                grvSearchDV.Columns["GIA"].HeaderText = "Giá";
                grvSearchDV.Columns["MOTA"].HeaderText = "Mô tả";

                grvSearchDV.Columns["DICHVUID"].Width = 50;
                grvSearchDV.Columns["TENDICHVU"].Width = 120;
                grvSearchDV.Columns["GIA"].Width = 100;
                grvSearchDV.Columns["MOTA"].Width = 190;
            }
            else
            {
                MessageBox.Show("No data found.");
            }

            // Close the connection
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string searchQuery = txtSearchDV.Text.Trim();

            // Call the method to load data with the search query
            LoadDichVuData(searchQuery);
        }
        private void LoadDichVuData(string searchQuery = "")
        {
            // Get the connection from connectDB class
            SqlConnection con = connectDB.GetConnection();

            // Make sure the connection is open
            if (con.State == ConnectionState.Closed)
                con.Open();

            // Define the query to get data from the DichVu table, adding search filtering if needed
            string query = "SELECT * FROM DichVu";
            if (!string.IsNullOrEmpty(searchQuery))
            {
                query += " WHERE TENDICHVU LIKE @SearchQuery"; // Search by service name
            }

            // Create the SqlDataAdapter to execute the query
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con);

            // Add parameter to prevent SQL injection
            dataAdapter.SelectCommand.Parameters.AddWithValue("@SearchQuery", "%" + searchQuery + "%");

            // Create a DataTable to hold the fetched data
            DataTable dataTable = new DataTable();

            // Fill the DataTable with the data from the database
            dataAdapter.Fill(dataTable);

            // Check if data was fetched successfully
            if (dataTable.Rows.Count > 0)
            {
                // Bind the data to the grvSearchDV DataGridView
                grvSearchDV.DataSource = dataTable;

                // Modify the column headers and widths AFTER binding the data
                grvSearchDV.Columns["DICHVUID"].HeaderText = "ID";
                grvSearchDV.Columns["TENDICHVU"].HeaderText = "Tên dịch vụ";
                grvSearchDV.Columns["GIA"].HeaderText = "Giá";
                grvSearchDV.Columns["MOTA"].HeaderText = "Mô tả";

                grvSearchDV.Columns["DICHVUID"].Width = 50;
                grvSearchDV.Columns["TENDICHVU"].Width = 120;
                grvSearchDV.Columns["GIA"].Width = 100;
                grvSearchDV.Columns["MOTA"].Width = 190;
            }
            else
            {
                MessageBox.Show("No data found.");
            }

            // Close the connection
            con.Close();
        }
        private void LoadPhongData()
        {
            // Get the connection from the connectDB class
            SqlConnection con = connectDB.GetConnection();

            // Make sure the connection is open
            if (con.State == ConnectionState.Closed)
                con.Open();

            // Define the query to get room numbers (SOPHONG) from DatPhong table and join with Phong table
            string query = @"
                SELECT p.SOPHONG
                FROM DatPhong dp
                JOIN Phong p ON dp.PHONGID = p.PHONGID
                WHERE dp.TINHTRANGDAT = N'Đang Đặt'"; // Assuming you only want to show rooms that are already booked

            // Create the SqlDataAdapter to execute the query
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con);

            // Create a DataTable to hold the fetched data
            DataTable dataTable = new DataTable();

            // Fill the DataTable with the data from the database
            dataAdapter.Fill(dataTable);

            // Check if data was fetched successfully
            if (dataTable.Rows.Count > 0)
            {
                // Clear existing items in ComboBox
                cbbphong.Items.Clear();

                // Add room numbers to the ComboBox
                foreach (DataRow row in dataTable.Rows)
                {
                    cbbphong.Items.Add(row["SOPHONG"].ToString());
                }
            }
            else
            {
                MessageBox.Show("No rooms found.");
            }

            // Close the connection
            con.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            int currentValue = 0;
            bool isValid = int.TryParse(txtsl.Text, out currentValue); // Try parsing the current value

            if (isValid && currentValue < 100)  // If valid number and less than 100
            {
                txtsl.Text = (currentValue + 1).ToString();  // Increment the value
            }
            else
            {
                // Optional: Show an error message if the value is invalid or exceeds 100
                MessageBox.Show("Value must be a number and less than or equal to 100.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int currentValue = 0;
            bool isValid = int.TryParse(txtsl.Text, out currentValue); // Try parsing the current value

            if (isValid && currentValue > 0)  // If valid number and greater than 0
            {
                txtsl.Text = (currentValue - 1).ToString();  // Decrement the value
            }
            else
            {
                // Optional: Show an error message if the value is invalid or 0
                MessageBox.Show("Value must be a number and greater than 0.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CalculateTotal()
        {
            // Ensure there is at least one row selected in the DataGridView
            if (grvSearchDV.SelectedRows.Count > 0)
            {
                // Get the price from the selected row (assuming the price column is named "GIA")
                decimal price = Convert.ToDecimal(grvSearchDV.SelectedRows[0].Cells["GIA"].Value);

                // Get the quantity from txtsl
                int quantity = 0;
                bool isValidQuantity = int.TryParse(txtsl.Text, out quantity);

                // Ensure the quantity is valid (non-negative and non-zero)
                if (isValidQuantity && quantity > 0)
                {
                    // Calculate the total price
                    decimal total = price * quantity;

                    // Display the total in txtSum
                    txtSum.Text = total.ToString("#,0.00 VNĐ");  // Formats the total as a currency value
                }
                else
                {
                    MessageBox.Show("Please enter a valid quantity.", "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                //MessageBox.Show("Please select a service.", "No Service Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtsl_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only numeric input (0-9)
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)  // 8 is the backspace key
            {
                e.Handled = true;  // Prevent the character from being typed
            }
        }

        private void txtsl_TextChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void grvSearchDV_SelectionChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void datdv_Click(object sender, EventArgs e)
        {
            int quantity;
            bool isQuantityValid = int.TryParse(txtsl.Text, out quantity);

            if (!isQuantityValid || quantity <= 0)
            {
                MessageBox.Show("Please enter a valid quantity.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get the selected service ID from the DataGridView
            if (grvSearchDV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a service.", "No Service Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int serviceId = Convert.ToInt32(grvSearchDV.SelectedRows[0].Cells["DICHVUID"].Value);

            // Get the selected date from DatePicker (dateTimePicker)
            DateTime selectedDate = dateTimePicker1.Value;

            // Get the room ID from the ComboBox
            string roomName = cbbphong.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(roomName)) 
            {
                MessageBox.Show("Hãy chọn 1 phòng để đặt dịch vụ", "No Room Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (roomName=="---Select---")
            {
                MessageBox.Show("Hãy chọn 1 phòng để đặt dịch vụ", "No Room Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Fetch the room ID from the room name in the database
            int roomId = GetRoomIdFromRoomName(roomName);
            if (roomId == -1)
            {
                MessageBox.Show("Invalid room selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Insert the data into the DatDichVu table
            InsertServiceBooking(roomId, serviceId, quantity, selectedDate);
        }
        private int GetRoomIdFromRoomName(string roomName)
        {
            int roomId = -1;
            // SQL to get the Room ID from the room name (SOPHONG)
            string query = "SELECT PHONGID FROM Phong WHERE SOPHONG = @RoomName";

            using (SqlConnection con = connectDB.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@RoomName", roomName);
                if (con.State == ConnectionState.Closed)
                    con.Open();
                var result = cmd.ExecuteScalar();

                if (result != null)
                {
                    roomId = Convert.ToInt32(result);
                }

                con.Close();
            }

            return roomId;
        }

        private void InsertServiceBooking(int roomId, int serviceId, int quantity, DateTime selectedDate)
        {
            // SQL query to insert the booking into the DatDichVu table
            string insertQuery = @"
                INSERT INTO DatDichVu (DATPHONGID, DICHVUID, GIA, NGAYDAT, SOLUONG)
                VALUES (@RoomId, @ServiceId, (SELECT GIA FROM DichVu WHERE DICHVUID = @ServiceId), @SelectedDate, @Quantity)";

            using (SqlConnection con = connectDB.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(insertQuery, con);
                cmd.Parameters.AddWithValue("@RoomId", roomId);
                cmd.Parameters.AddWithValue("@ServiceId", serviceId);
                cmd.Parameters.AddWithValue("@SelectedDate", selectedDate);
                cmd.Parameters.AddWithValue("@Quantity", quantity);
                if (con.State == ConnectionState.Closed)
                    con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }

            MessageBox.Show("Đặt dịch vụ cho phòng thành công" , "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadDataIntoGrvDVdaDat();
        }
    }
}
