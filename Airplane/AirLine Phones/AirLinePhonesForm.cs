using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Airplane.AirLine_Address;
using Microsoft.Data.SqlClient;

namespace Airplane.AirLine_Phones
{
    public partial class AirLinePhonesForm : Form
    {
        private double CurrentRowIndex = -1;
        private AirLinePhonesClass airLinePHN;
        public AirLinePhonesForm()
        {
            InitializeComponent();
            loadData();
            loadDataAirline();
        }
        public void loadData()
        {
            using SqlConnection sqlConnection = new SqlConnection(ConnectionToDB.ConnectionString);
            string query = "SELECT * FROM AirLine_Phones";
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
            combo_airId.ValueMember = "Airline_ID";
            combo_airId.DataSource = dataTable;
        }
        private void button1_Click(object sender, EventArgs e)
        {

            string AirLine_ID = combo_airId.Text.Trim();
            string Phones = phoTXT.Text.Trim();

            if (AirLine_ID != "" && Phones != "")
            {

                try
                {
                    string connection = ConnectionToDB.ConnectionString;
                    SqlConnection sqlConnection = new SqlConnection(connection);
                    string query = "INSERT INTO AirLine_Phones ( Airline_ID, Phones) VALUES (@Alid,@phone)";
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlConnection.Open();


                    sqlCommand.Parameters.AddWithValue("@Alid", AirLine_ID);
                    sqlCommand.Parameters.AddWithValue("@phone", Phones);


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
        private void DeleteBTN_Click_1(object sender, EventArgs e)
        {
            // delete
            var result = MessageBox.Show("Are you sure you want to delete this Airline Address?", "Delete Address", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    string connection = ConnectionToDB.ConnectionString;
                    SqlConnection sqlConnection = new SqlConnection(connection);
                    string query = $"DELETE FROM AirLine_Phones WHERE Airline_ID = {CurrentRowIndex}";
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

        private void dgvAddress_RowEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvAddress.Rows[e.RowIndex];


            airLinePHN = new AirLinePhonesClass();
            airLinePHN.AirLine_ID = Convert.ToString(row.Cells["Airline_ID"].Value);
            airLinePHN.phone = Convert.ToString(row.Cells["Phones"].Value);


            if (row.Cells["Airline_ID"].Value != null && double.TryParse(row.Cells["Airline_ID"].Value.ToString(), out double idValue))
            {
                CurrentRowIndex = idValue;
            }
            else
            {
                CurrentRowIndex = -1; // Or handle the error appropriately  
            }
        }

        private void UpdateBtn_Click_1(object sender, EventArgs e)
        {
            UpdateAirLinePhonesForm form = new UpdateAirLinePhonesForm(this, airLinePHN);
            form.ShowDialog();

        }
    }
}
