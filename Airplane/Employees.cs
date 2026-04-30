using System.Data;
using System.Runtime.Intrinsics.X86;
using Microsoft.Data.SqlClient;

namespace Airplane
{
    public partial class Employees : Form
    {
        private double CurrentRowIndex = -1;
        private Employee emp;
        public Employees()
        {
            InitializeComponent();
            loadData();
            loadDataAirline();
        }
        public void loadData()
        {
            using SqlConnection sqlConnection = new SqlConnection(ConnectionToDB.ConnectionString);
            string query = "SELECT * FROM Employee";
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, sqlConnection);
            dataAdapter.Fill(dataTable);
            dgv_employee.DataSource = dataTable;
        }
        private void loadDataAirline()
        {
            using SqlConnection sqlConnection = new SqlConnection(ConnectionToDB.ConnectionString);
            string query = "SELECT * FROM AirLine";
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, sqlConnection);
            dataAdapter.Fill(dataTable);

            AirCombo.DisplayMember = "Air_Id";
            AirCombo.ValueMember = "Air_ID"; //emp table
            AirCombo.DataSource = dataTable;
        }

        private void inertBtn_Click(object sender, EventArgs e)
        {
            string ssn = ssnTxt.Text.Trim();
            string Fname = fnameTxt.Text.Trim();
            string Lname = lnameTxt.Text.Trim();
            string position = PositTxt.Text.Trim();
            string gender;
            if (MaleRD.Checked == true)
            {
                gender = MaleRD.Text;
            }
            else
            {
                gender = FemaleRD.Text;
            }

            DateTime BirthDay = Convert.ToDateTime(dtp_bday.Text);


            string airId = AirCombo.Text;


            if (ssn != "" && Fname != "" && position != "" && gender != "" && airId != "")
            {
                try
                {
                    string connection = ConnectionToDB.ConnectionString;
                    SqlConnection sqlConnection = new SqlConnection(connection);
                    string query = "INSERT INTO Employee (SSN,Fname,Lname,position,Gender,Brithday,Air_ID) VALUES (@id,@first,@last,@posit,@gend,@bday,@airId )";
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlConnection.Open();

                    sqlCommand.Parameters.AddWithValue("@id", ssn);
                    sqlCommand.Parameters.AddWithValue("@first", Fname);
                    sqlCommand.Parameters.AddWithValue("@last", Lname);
                    sqlCommand.Parameters.AddWithValue("@posit", position);
                    sqlCommand.Parameters.AddWithValue("@gend", gender);
                    sqlCommand.Parameters.AddWithValue("@bday", BirthDay);
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
            var result = MessageBox.Show("Are you sure you want to delete this employee?", "Delete Employee", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    string connection = ConnectionToDB.ConnectionString;
                    SqlConnection sqlConnection = new SqlConnection(connection);
                    string query = $"DELETE FROM Employee WHERE SSN = {CurrentRowIndex}";
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

        private void dgv_employee_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

            var row = dgv_employee.Rows[e.RowIndex];


            emp = new Employee();
            emp.Ssn = Convert.ToString(row.Cells["SSN"].Value);
            emp.Fname = Convert.ToString(row.Cells["Fname"].Value);
            emp.Lname = Convert.ToString(row.Cells["Lname"].Value);
            emp.Position = Convert.ToString(row.Cells["position"].Value);
            emp.Gender = Convert.ToString(row.Cells["Gender"].Value);
            emp.BirthDay = Convert.ToDateTime(row.Cells["Brithday"].Value);
            emp.AirId = Convert.ToString(row.Cells["Air_ID"].Value);

            if (row.Cells["SSN"].Value != null && double.TryParse(row.Cells["SSN"].Value.ToString(), out double ssnValue))
            {
                CurrentRowIndex = ssnValue;
            }
            else
            {
                CurrentRowIndex = -1;
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            UpdateEmployees form = new UpdateEmployees(emp, this);
            form.ShowDialog();


        }

        private void Employees_Load(object sender, EventArgs e)
        {

        }
    }


}

