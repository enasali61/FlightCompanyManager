using System.Windows.Forms.Design;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;



namespace Airplane.AirLine_Address
{
    public partial class UpdateAddress : Form
    {
        private string originalId;
        private AirlineAddForm mainForm { get; set; }
        public UpdateAddress(AirlineAddForm form, AirLine_AddressClass airlineAdd)
        {
            InitializeComponent();
            loadDataAirline();
           
            mainForm = form;

            originalId = Convert.ToString(airlineAdd.AirID);

            combo_airId.Text = Convert.ToString(airlineAdd.AirID);

            addTXT.Text = Convert.ToString(airlineAdd.AirAddress);
        }

        private void loadDataAirline()
        {
            using SqlConnection sqlConnection = new SqlConnection(ConnectionToDB.ConnectionString);
            string query = "SELECT Air_id FROM AirLine";
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, sqlConnection);
            dataAdapter.Fill(dataTable);

            combo_airId.DisplayMember = "Air_Id";
            combo_airId.ValueMember = "Air_id";
            combo_airId.DataSource = dataTable;
        }
        private void updateBtn_Click(object sender, EventArgs e)
        {

            string address = addTXT.Text.Trim();

            string NewAirId = combo_airId.Text.Trim();


            string query = " UPDATE Airline_address SET Air_id=@id,addr=@address WHERE Air_id =@AirId  ";


            if (NewAirId != "" && address != "")
            {
                try
                {
                    string connection = ConnectionToDB.ConnectionString;
                    SqlConnection sqlConnection = new SqlConnection(connection);
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlConnection.Open();

                    sqlCommand.Parameters.AddWithValue("@id", NewAirId);
                    sqlCommand.Parameters.AddWithValue("@address", address);
                    sqlCommand.Parameters.AddWithValue("@AirId", originalId);

                    int rows = sqlCommand.ExecuteNonQuery();

                    MessageBox.Show($"{rows} row Succesfully updated");

                    mainForm.loadData();
                    sqlCommand.Parameters.Clear();

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

        private void airIdLBL_Click(object sender, EventArgs e)
        {

        }
    }
}
