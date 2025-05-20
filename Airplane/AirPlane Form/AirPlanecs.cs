using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Airplane.AirPlane_Form
{
    public partial class AirPlanecs : Form
    {
        private double CurrentRowIndex;
        private AirPlane Airplane;
        public AirPlanecs()
        {
            InitializeComponent();
            loadData();
            loadDataAirline();
        }
        public void loadData()
        {
            using SqlConnection sqlConnection = new SqlConnection(ConnectionToDB.ConnectionString);
            string query = "SELECT * FROM AirPlane";
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, sqlConnection);
            dataAdapter.Fill(dataTable);
            dgv_airplane.DataSource = dataTable;
        }
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


        private void InsertBtn_Click(object sender, EventArgs e)
        {

            string id = idTxt.Text.Trim();
            string model = modelTxt.Text.Trim();
            int capacity = Convert.ToInt32(capacityTXT.Text.Trim());
            string maj_pilot = maj_pilotTxt.Text.Trim();
            string assist_pilot = assist_pilotTXT.Text.Trim();
            string host1 = host1TXT.Text.Trim();
            string host2 = host2TXT.Text.Trim();
            string airId = combo_Airid.Text;


            if (id != "" && model != "" && capacity != 0 && maj_pilot != "" && assist_pilot != "" && host1 != "" && airId != "")
            {
                try
                {

                    string connection = ConnectionToDB.ConnectionString;
                    SqlConnection sqlConnection = new SqlConnection(connection);
                    string query = "INSERT INTO AirPlane (id,model,capacity,maj_pilot,assist_pilot,host1,host2,A_id) VALUES (@id,@model,@cap,@maj,@assist,@host1,@host2,@airId )";
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlConnection.Open();

                    sqlCommand.Parameters.AddWithValue("@id", id);
                    sqlCommand.Parameters.AddWithValue("@model", model);
                    sqlCommand.Parameters.AddWithValue("@cap", capacity);
                    sqlCommand.Parameters.AddWithValue("@maj", maj_pilot);
                    sqlCommand.Parameters.AddWithValue("@assist", assist_pilot);
                    sqlCommand.Parameters.AddWithValue("@host1", host1);
                    sqlCommand.Parameters.AddWithValue("@host2", host2);
                    sqlCommand.Parameters.AddWithValue("@airId", airId);

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
            var result = MessageBox.Show("Are you sure you want to delete this airplane?", "Delete AirPlane", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    string connection = ConnectionToDB.ConnectionString;
                    SqlConnection sqlConnection = new SqlConnection(connection);
                    string query = $"DELETE FROM AirPlane WHERE id = @id";

                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@id", CurrentRowIndex);

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


        private void dgv_airplane_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgv_airplane.Rows[e.RowIndex];

            Airplane = new AirPlane();
            Airplane.Id = Convert.ToString(row.Cells["id"].Value);
            Airplane.Model = Convert.ToString(row.Cells["model"].Value);
            Airplane.Capacity = Convert.ToInt32(row.Cells["capacity"].Value);
            Airplane.Maj_Pilot = Convert.ToString(row.Cells["maj_pilot"].Value);
            Airplane.Assist_Pilot = Convert.ToString(row.Cells["assist_pilot"].Value);
            Airplane.Host1 = Convert.ToString(row.Cells["host1"].Value);
            Airplane.Host2 = Convert.ToString(row.Cells["host2"].Value);
            Airplane.AirId = Convert.ToString(row.Cells["A_id"].Value);

            if (row.Cells["id"].Value != null && double.TryParse(row.Cells["id"].Value.ToString(), out double idValue))
            {
                CurrentRowIndex = idValue;
            }
            else
            {
                CurrentRowIndex = -1; 
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            UpdateAirPlane form = new UpdateAirPlane(Airplane, this);
            form.ShowDialog();
        }
    }
}
