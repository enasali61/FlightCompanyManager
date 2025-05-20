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

namespace Airplane.AirLine
{
    
    public partial class UpdateAirline : Form
    {
        private Airline mainForm;
        private string originalid;

        public UpdateAirline(AirLines airLi,Airline form)
        {
            InitializeComponent();

            mainForm = form;

            AiridTXT.Text = Convert.ToString(airLi.AirLine_id);
            NameTXT.Text = Convert.ToString(airLi.Name);
            originalid = Convert.ToString(airLi.AirLine_id);

        }
        private void button2_Click(object sender, EventArgs e)
        {
            // update
            
            string Air_id = AiridTXT.Text.Trim();
            string name = NameTXT.Text.Trim();


            string query = " UPDATE AirLine SET Air_Id = @Air_id , Name = @name WHERE Air_Id = @oldid";


            if (Air_id != "" && name != "")
            {
                try
                {
                    string connection = ConnectionToDB.ConnectionString;
                    SqlConnection sqlConnection = new SqlConnection(connection);
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlConnection.Open();

                    sqlCommand.Parameters.AddWithValue("@Air_id", Air_id);
                    sqlCommand.Parameters.AddWithValue("@name", name);  
                    sqlCommand.Parameters.AddWithValue("@oldid", originalid);


                    int rows = sqlCommand.ExecuteNonQuery();

                    MessageBox.Show($"{rows} row Succesfully Inserted");

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
    }
}
