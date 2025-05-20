using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Airplane.AirLine_Address
{
    public partial class AirlineAddForm : Form
    {
        
        private double CurrentRowIndex = -1;
        private AirLine_AddressClass airLineADD;
        public AirlineAddForm()
        {
            InitializeComponent();
            loadData();
            loadDataAirline();

        }
        public void loadData()
        {
            using SqlConnection sqlConnection = new SqlConnection(ConnectionToDB.ConnectionString);
            string query = "SELECT * FROM Airline_address";
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, sqlConnection);
            dataAdapter.Fill(dataTable);
            dgvAddress.DataSource = dataTable;
        }
        private void loadDataAirline()
        {
            using SqlConnection sqlConnection = new SqlConnection(ConnectionToDB.ConnectionString);
            string query = "SELECT * FROM AirLine";
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, sqlConnection);
            dataAdapter.Fill(dataTable);

            combo_airId.DisplayMember = "Air_Id";
            combo_airId.ValueMember = "Air_id";
            combo_airId.DataSource = dataTable;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            // insert

            string AirId = combo_airId.Text.Trim();
            string address = addTXT.Text.Trim();

            if (AirId != "" && address != "")
            {

                try
                {
                    string connection = ConnectionToDB.ConnectionString;
                    SqlConnection sqlConnection = new SqlConnection(connection);
                    string query = "INSERT INTO Airline_address (Air_id,addr) VALUES (@id,@address)";
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlConnection.Open();


                    sqlCommand.Parameters.AddWithValue("@id", AirId);
                    sqlCommand.Parameters.AddWithValue("@address", address);


                    int rows = sqlCommand.ExecuteNonQuery();

                    MessageBox.Show($"{rows} row Succesfully Inserted");

                    sqlCommand.Parameters.Clear();
                    loadData();
                    sqlConnection.Close();
                }




                catch (SqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }


            else
            {
                MessageBox.Show("Please fill all fields");
            }
        }


        private void DeleteBTN_Click(object sender, EventArgs e)
        {
 // delete
            var result = MessageBox.Show("Are you sure you want to delete this Airline Address?", "Delete Address", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    string connection = ConnectionToDB.ConnectionString;
                    SqlConnection sqlConnection = new SqlConnection(connection);
                    string query = $"DELETE FROM Airline_address WHERE Air_id = {CurrentRowIndex}";
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlConnection.Open();

                    int rows = sqlCommand.ExecuteNonQuery();

                    MessageBox.Show($"{rows} row Succesfully deleted");


                    loadData();

                    sqlConnection.Close();

                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void dgvAddress_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvAddress.Rows[e.RowIndex];


            airLineADD = new AirLine_AddressClass();
            airLineADD.AirID = Convert.ToString(row.Cells["Air_id"].Value);
            airLineADD.AirAddress = Convert.ToString(row.Cells["addr"].Value);


            if (row.Cells["Air_id"].Value != null && double.TryParse(row.Cells["Air_id"].Value.ToString(), out double idValue))
            {
                CurrentRowIndex = idValue;
            }
            else
            {
                CurrentRowIndex = -1; // Or handle the error appropriately  
            }

        }
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            UpdateAddress form = new UpdateAddress(this, airLineADD);
            form.ShowDialog();

        }

        
    }
}
