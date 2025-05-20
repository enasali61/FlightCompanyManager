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

namespace Airplane.Route
{
    public partial class Routes : Form
    {
        private double CurrentRowIndex = -1;
        private Route route;
        public Routes()
        {
            InitializeComponent();
            loadData();
        }
        public void loadData()
        {

            using SqlConnection Connection = new SqlConnection(ConnectionToDB.ConnectionString);
            string query = "SELECT * FROM Route";
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, Connection);
            dataAdapter.Fill(dataTable);
            dgv_Route.DataSource = dataTable;

        }

        private void inertBtn_Click(object sender, EventArgs e)
        {

            string Routeid = routeIdTXT.Text.Trim();
            decimal Distance = Convert.ToDecimal(distanceTXT.Text.Trim());
            string Distenation = destinationTXT.Text.Trim();
            if (Routeid != "")
            {

                try
                {

                    string connection = ConnectionToDB.ConnectionString;
                    SqlConnection sqlConnection = new SqlConnection(connection);
                    string query = "INSERT INTO Route (RouteId,Distance,Destination) VALUES (@id,@distace,@destination)";
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlConnection.Open();


                    sqlCommand.Parameters.AddWithValue("@id", Routeid);
                    sqlCommand.Parameters.AddWithValue("@distace", Distance);
                    sqlCommand.Parameters.AddWithValue("@destination", Distenation);


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

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to delete this route?", "Delete Route", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    string connection = ConnectionToDB.ConnectionString;
                    SqlConnection sqlConnection = new SqlConnection(connection);
                    string query = $"DELETE FROM Route WHERE RouteId = {CurrentRowIndex}";
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
        private void dgv_Route_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgv_Route.Rows[e.RowIndex];


            route = new Route();
            route.Routeid = Convert.ToString(row.Cells["RouteId"].Value);
            route.Distance = Convert.ToDecimal(row.Cells["Distance"].Value);
            route.Distenation = Convert.ToString(row.Cells["Destination"].Value);

            if (row.Cells["RouteId"].Value != null && double.TryParse(row.Cells["RouteId"].Value.ToString(), out double idValue))
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
            RouteUpdating form = new RouteUpdating(route, this);
            form.ShowDialog();
        }

        
    }
}
