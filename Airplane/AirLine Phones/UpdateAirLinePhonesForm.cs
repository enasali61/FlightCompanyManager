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
using Microsoft.VisualBasic;

namespace Airplane.AirLine_Phones
{
    public partial class UpdateAirLinePhonesForm : Form
    {
        private string originalId;
        private AirLinePhonesForm Mainform;
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
       public UpdateAirLinePhonesForm(AirLinePhonesForm form, AirLinePhonesClass airLine)
        {
            InitializeComponent();
            loadDataAirline();


            Mainform = form;

            originalId = Convert.ToString(airLine.AirLine_ID);
            phoTXT.Text = Convert.ToString(airLine.phone);
            combo_airId.Text = Convert.ToString(airLine.AirLine_ID);
            
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            string AirLine_ID = combo_airId.Text.Trim();
            string phone = phoTXT.Text.Trim();

            string query = "UPDATE AirLine_Phones SET Airline_ID =@Alid, Phones=@phone WHERE Airline_ID =@AirId "; 
            
            if (AirLine_ID != "" && phone != "")
            {

                try
                {

                    string connection = ConnectionToDB.ConnectionString;
                    SqlConnection sqlConnection = new SqlConnection(connection);
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlConnection.Open();
                    sqlCommand.Parameters.AddWithValue("@Alid", AirLine_ID);
                    sqlCommand.Parameters.AddWithValue("@phone", phone);
                    sqlCommand.Parameters.AddWithValue("@AirId",originalId);
                    

                    int rows = sqlCommand.ExecuteNonQuery();

                    MessageBox.Show($"{rows} row Succesfully Updatted");
                    
                    Mainform.loadData();     
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
    }
}
