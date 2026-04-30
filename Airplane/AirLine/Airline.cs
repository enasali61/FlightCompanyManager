using System.Data;
using Microsoft.Data.SqlClient;

namespace Airplane.AirLine
{
    public partial class Airline : Form
    {
        private double CurrentRowIndex = -1;
        private AirLines airLine;
        public Airline()
        {
            InitializeComponent();
            loadData();
        }
        public void loadData()
        {
            SqlConnection sqlconnection = new SqlConnection(ConnectionToDB.ConnectionString);
            string query = "SELECT * FROM AirLine";
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, sqlconnection);
            dataAdapter.Fill(dataTable);
            dgv_airline.DataSource = dataTable;
        }
        //insert
        private void button1_Click(object sender, EventArgs e)
        {
            string AirLine_id = AiridTXT.Text.Trim();
            string name = NameTXT.Text.Trim();
            string query = "INSERT INTO AirLine(Air_Id,Name)VALUES(@AirLine_id,@name)";

            try
            {
                string con_string = ConnectionToDB.ConnectionString;
                SqlConnection cn = new SqlConnection(con_string);
                SqlCommand sqlcommand = new SqlCommand(query, cn);

                if (string.IsNullOrWhiteSpace(AirLine_id) || string.IsNullOrWhiteSpace(name))
                {
                    MessageBox.Show("Airline ID and Name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    cn.Open();
                    sqlcommand.Parameters.AddWithValue("@AirLine_id", AirLine_id);
                    sqlcommand.Parameters.AddWithValue("@name", name);

                    int rows = sqlcommand.ExecuteNonQuery();

                    MessageBox.Show($"{rows} row Succesfully Inserted");

                    sqlcommand.Parameters.Clear();
                    loadData();
                    cn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // delete
            var result = MessageBox.Show("Are you sure you want to delete this airline?", "Delete AirLine", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    string connection = ConnectionToDB.ConnectionString;
                    SqlConnection sqlConnection = new SqlConnection(connection);
                    string query = $"DELETE FROM AirLine WHERE Air_Id = {CurrentRowIndex}";
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


        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgv_airline.Rows[e.RowIndex];

            airLine = new AirLines();
            airLine.AirLine_id = Convert.ToString(row.Cells["Air_Id"].Value);
            airLine.Name = Convert.ToString(row.Cells["Name"].Value);

            if (row.Cells["Air_Id"].Value != null && double.TryParse(row.Cells["Air_Id"].Value.ToString(), out double AirLine_idValue))
            {
                CurrentRowIndex = AirLine_idValue;
            }
            else
            {
                CurrentRowIndex = -1; // Or handle the error appropriately   
            }

        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            UpdateAirline form = new UpdateAirline(airLine, this);
            form.ShowDialog();
        }
    }
}
