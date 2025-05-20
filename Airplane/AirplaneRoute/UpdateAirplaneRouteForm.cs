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

namespace Airplane.AirplaneRoute
{
    public partial class UpdateAirplaneRouteForm : Form
    {
        private string originalId;
        private AirplaneRouteForm Form;

        
        private void loadDataAirPlane()
        {
            using SqlConnection Connection = new SqlConnection(ConnectionToDB.ConnectionString);
            string query = "SELECT * FROM AirPlane";
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, Connection);
            dataAdapter.Fill(dataTable);


            comboAirplene.DisplayMember = "id";
            comboAirplene.ValueMember = "Ap_Id";
            comboAirplene.DataSource = dataTable;

        }
        private void loadDataRouteId()
        {
            using SqlConnection Connection = new SqlConnection(ConnectionToDB.ConnectionString);
            string query = "SELECT * FROM Route";
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, Connection);
            dataAdapter.Fill(dataTable);

            combRoute.DisplayMember = "RouteId";
            combRoute.ValueMember = "Rt_Id";
            combRoute.DataSource = dataTable;
        }
        public UpdateAirplaneRouteForm(AirplaneRouteClass airplaneRouteClass,AirplaneRouteForm form)
        {
            InitializeComponent();
            loadDataAirPlane();
            loadDataRouteId();
            
            Form = form;


            comboAirplene.Text = Convert.ToString(airplaneRouteClass.airplaneId);
            combRoute.Text = Convert.ToString(airplaneRouteClass.RouteId);
            PriceTXT.Text = Convert.ToString(airplaneRouteClass.Price);
            DurationTXT.Text = Convert.ToString(airplaneRouteClass.Duration);
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            string Ap_Id = comboAirplene.Text;
            string Rt_Id = combRoute.Text;
            string Price = PriceTXT.Text.Trim();
            string Duration = DurationTXT.Text.Trim();
            originalId = combRoute.Text;


            string query = "UPDATE AirPlane_Route  SET Rt_Id =@Rtid ,Ap_Id=@Apid, price=@price, Durations=@duration  WHERE Rt_Id = @oldId";
           
            if (Ap_Id != "" && Rt_Id != "" && Price != "")
            {

                try
                {


                    string connection = ConnectionToDB.ConnectionString;
                    SqlConnection sqlConnection = new SqlConnection(connection);
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                    sqlConnection.Open();

                    sqlCommand.Parameters.AddWithValue("@Apid", Ap_Id);
                    sqlCommand.Parameters.AddWithValue("@Rtid", Rt_Id);
                    sqlCommand.Parameters.AddWithValue("@price", Price);
                    sqlCommand.Parameters.AddWithValue("@duration", Duration);
                    sqlCommand.Parameters.AddWithValue("@oldId", originalId);




                    int rows = sqlCommand.ExecuteNonQuery();

                    MessageBox.Show($"{rows} row Succesfully Updated");

                    sqlCommand.Parameters.Clear();

                    Form.loadData();
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
