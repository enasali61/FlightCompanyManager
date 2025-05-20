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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Airplane.AirplaneRoute
{
    public partial class AirplaneRouteForm : Form
    {
        private double CurrentRowIndex = -1;
        private AirplaneRouteClass airplane_Route;
        public AirplaneRouteForm()
        {
            InitializeComponent();
            loadData();   
            loadDataRouteId(); 
            loadDataAirPlane();
        }
        public void loadData()
        {

            using SqlConnection Connection = new SqlConnection(ConnectionToDB.ConnectionString);
            string query = "SELECT * FROM AirPlane_Route";
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, Connection);
            dataAdapter.Fill(dataTable);

            dgv_airRoute.DataSource = dataTable;

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

        private void button1_Click(object sender, EventArgs e)
        {
            
            string Price = PriceTXT.Text.Trim();
            string Duration = DurationTXT.Text.Trim();
            string Ape_Id = comboAirplene.Text;
            string Rte_Id = combRoute.Text;
             

            string query = "INSERT INTO AirPlane_Route (Rt_Id ,Ap_Id, price, Durations) VALUES (@Rtid,@Apid,@price,@duration)";
            
            if (Ape_Id != "" && Rte_Id != "" && Price != "")
            {

                try
                {

                    string connection = ConnectionToDB.ConnectionString;
                    SqlConnection sqlConnection = new SqlConnection(connection);
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlConnection.Open();

                    sqlCommand.Parameters.AddWithValue("@Apid", Ape_Id);
                    sqlCommand.Parameters.AddWithValue("@Rtid", Rte_Id);
                    sqlCommand.Parameters.AddWithValue("@price", Price);
                    sqlCommand.Parameters.AddWithValue("@duration", Duration);




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

        private void dltbutton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to delete this AirPlane_Route?", "Delete AirPlane_Route", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    string connection = ConnectionToDB.ConnectionString;
                    SqlConnection sqlConnection = new SqlConnection(connection);
                    string query = $"DELETE FROM AirPlane_Route WHERE Ap_Id = {CurrentRowIndex} ";
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
        private void dgv_airRoute_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgv_airRoute.Rows[e.RowIndex];

            airplane_Route = new AirplaneRouteClass();
            airplane_Route.RouteId = Convert.ToString(row.Cells["Rt_Id"].Value);
            airplane_Route.airplaneId = Convert.ToString(row.Cells["Ap_Id"].Value);
            airplane_Route.Price = Convert.ToDecimal(row.Cells["price"].Value);
            airplane_Route.Duration = Convert.ToInt32(row.Cells["Durations"].Value);

            if (row.Cells["Ap_Id"].Value != null && double.TryParse(row.Cells["Ap_Id"].Value.ToString(), out double idValue))
            {
                CurrentRowIndex = idValue;
            }
            else
            {
                CurrentRowIndex = -1; // Or handle the error appropriately  
            }
        }
        private void updateBtn_Click(object sender, EventArgs e)
        {
            UpdateAirplaneRouteForm mform = new UpdateAirplaneRouteForm(airplane_Route, this);
            mform.ShowDialog();
        }
    }
}
