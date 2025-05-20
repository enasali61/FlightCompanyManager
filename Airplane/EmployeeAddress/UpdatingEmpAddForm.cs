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

namespace Airplane.EmployeeAddress
{
    public partial class UpdatingEmpAddForm : Form
    {
        private string originalId;
        private EmpAddForm Mainform;
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
        public UpdatingEmpAddForm(EmpAddForm form, EmpAddClass emp)
        {
            InitializeComponent();loadDataSSN();
            Mainform = form;

            originalId = Convert.ToString(emp.EmployeeSSN);
            combo_ssn.Text = Convert.ToString(emp.EmployeeSSN);
            addTXT.Text = Convert.ToString(emp.Address);
        }


        private void UpdateBtn_Click(object sender, EventArgs e)
        {

            string Essn = combo_ssn.Text.Trim();
            string Eaddr = addTXT.Text.Trim();

            string query = "UPDATE Employee_addr SET Essn=@Essn, Eaddr=@Eaadr WHERE Essn = @oldssn";
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
                    sqlCommand.Parameters.AddWithValue("@oldssn", originalId);



                    

                    int rows = sqlCommand.ExecuteNonQuery();

                    MessageBox.Show($"{rows} row Succesfully Inserted");

                    sqlCommand.Parameters.Clear();


                    Mainform.loadData();


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
