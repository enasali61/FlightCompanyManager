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

namespace Airplane.AirPlane_Form
{
    public partial class UpdateAirPlane : Form
    {
        private void loadDataAirline()
        {
            using SqlConnection sqlConnection = new SqlConnection(ConnectionToDB.ConnectionString);
            string query = "SELECT * FROM AirLine";
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, sqlConnection);
            dataAdapter.Fill(dataTable);

            combo_Airid.DisplayMember = "Air_Id";
            combo_Airid.ValueMember = "A_id";
            combo_Airid.DataSource = dataTable;
        }

        private string originalId;
        private AirPlanecs mainForm { get; set; }
        public UpdateAirPlane(AirPlane airplane, AirPlanecs form)
        {
            InitializeComponent();
            loadDataAirline();
            mainForm = form;

            originalId = Convert.ToString(airplane.Id); //original
            idTxt.Text = Convert.ToString(airplane.Id); //updated   

            modelTxt.Text = Convert.ToString(airplane.Model);
            capacityTXT.Text = Convert.ToString(airplane.Capacity);
            maj_pilotTxt.Text = Convert.ToString(airplane.Maj_Pilot);
            assist_pilotTXT.Text = Convert.ToString(airplane.Assist_Pilot);
            host1TXT.Text = Convert.ToString(airplane.Host1);
            host2TXT.Text = Convert.ToString(airplane.Host2);
            combo_Airid.Text = Convert.ToString(airplane.AirId);
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            string newId = idTxt.Text.Trim();
            string model = modelTxt.Text.Trim();
            int capacity = Convert.ToInt32( capacityTXT.Text.Trim());
            string maj_pilot = maj_pilotTxt.Text.Trim();
            string assist_pilot = assist_pilotTXT.Text.Trim();
            string host1 = host1TXT.Text.Trim();
            string host2 = host2TXT.Text.Trim();            
            string airId = combo_Airid.Text;


            string query = " UPDATE AirPlane SET id=@id,model=@model,capacity=@cap,maj_pilot=@maj,assist_pilot=@assist,host1=@host1,host2=@host2,A_id=@airId WHERE id =@oldId ";


            if (newId != "" && model != "" && capacity != 0 && maj_pilot != "" && assist_pilot != "" && host1 != "" && airId != "")
            {
                try
                {
                    string connection = ConnectionToDB.ConnectionString;
                    SqlConnection sqlConnection = new SqlConnection(connection);
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlConnection.Open();
                    
                    sqlCommand.Parameters.AddWithValue("@id", newId);
                    sqlCommand.Parameters.AddWithValue("@model", model);
                    sqlCommand.Parameters.AddWithValue("@cap", capacity);
                    sqlCommand.Parameters.AddWithValue("@maj", maj_pilot);
                    sqlCommand.Parameters.AddWithValue("@assist", assist_pilot);
                    sqlCommand.Parameters.AddWithValue("@host1", host1);
                    sqlCommand.Parameters.AddWithValue("@host2", host2);
                    sqlCommand.Parameters.AddWithValue("@airId", airId);
                    sqlCommand.Parameters.AddWithValue("@oldId", originalId);

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
