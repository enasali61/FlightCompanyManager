using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Airplane.AirLine_Phones;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic;

namespace Airplane.EmployeeAddress
{
    public partial class EmpAddForm : Form
    {
        private decimal CurrentRowIndex = -1;
        private EmpAddClass empAdd;
        public EmpAddForm()
        {
            InitializeComponent();
            loadData();
            loadDataSSN();
        }
        public void loadData()
        {
            using SqlConnection sqlConnection = new SqlConnection(ConnectionToDB.ConnectionString);
            string query = "SELECT * FROM Employee_addr";
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, sqlConnection);
            dataAdapter.Fill(dataTable);
            dgvEMPAddress.DataSource = dataTable;
        }
        private void loadDataSSN()
        {
            using SqlConnection sqlConnection = new SqlConnection(ConnectionToDB.ConnectionString);
            string query = "SELECT * FROM Employee";
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, sqlConnection);
            dataAdapter.Fill(dataTable);

            combo_ssn.DisplayMember = "SSN";
            combo_ssn.ValueMember = "Essn";
            combo_ssn.DataSource = dataTable;
        }

        private void InserBTN_Click(object sender, EventArgs e)
        {


            string Essn = combo_ssn.Text;
            string Eaddr = addTXT.Text.Trim();




            string query = "INSERT INTO Employee_addr (Essn, Eaddr) VALUES (@Essn,@Eaadr)";
            if (Essn != "" && Eaddr != "")
            {

                try
                {

                    string connection = ConnectionToDB.ConnectionString;
                    SqlConnection sqlConnection = new SqlConnection(connection);
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlConnection.Open();

                    
                        sqlCommand.Parameters.AddWithValue("@Essn", Essn);
                   
                    
                    sqlCommand.Parameters.AddWithValue("@Eaadr", Eaddr);





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

        private void DeleteBTN_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to delete this employee address?", "Delete Employee Address", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {


                try
                {

                    string connection = ConnectionToDB.ConnectionString;
                    SqlConnection sqlConnection = new SqlConnection(connection);
                    string query = "DELETE FROM Employee_addr WHERE Essn = @Essn";
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@Essn", CurrentRowIndex.ToString());

                    sqlConnection.Open();

                    int rows = sqlCommand.ExecuteNonQuery();

                    MessageBox.Show($"{rows} row successfully deleted");
                    loadData();

                    sqlConnection.Close();

                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

            }
        }
                
        private void dgvEMPAddress_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvEMPAddress.Rows[e.RowIndex];


            empAdd = new EmpAddClass();
            empAdd.EmployeeSSN = Convert.ToString(row.Cells["Essn"].Value);
            empAdd.Address = Convert.ToString(row.Cells["Eaddr"].Value);


            if (row.Cells["Essn"].Value != null && decimal.TryParse(row.Cells["Essn"].Value.ToString(), out decimal idValue))
            {
                CurrentRowIndex = idValue;
            }
            else
            {
                CurrentRowIndex = -1; // Or handle the error appropriately  
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            UpdatingEmpAddForm form = new UpdatingEmpAddForm(this, empAdd);
            form.ShowDialog();
        }
    }
}
