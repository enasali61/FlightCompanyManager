using System.Data;
using Microsoft.Data.SqlClient;

namespace Airplane
{
    public partial class UpdateEmployees : Form
    {

        private void loadDataAirline()
        {
            using SqlConnection sqlConnection = new SqlConnection(ConnectionToDB.ConnectionString);
            string query = "SELECT Air_Id FROM AirLine";
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, sqlConnection);
            dataAdapter.Fill(dataTable);

            AirCombo.DisplayMember = "Air_Id";
            AirCombo.ValueMember = "Air_ID";
            AirCombo.DataSource = dataTable;
        }

        private string originalSSN;
        private Employees mainForm { get; set; }
        public UpdateEmployees(Employee employee, Employees form)
        {
            InitializeComponent();
            loadDataAirline();


            mainForm = form;

            originalSSN = Convert.ToString(employee.Ssn);

            newSsnTxt.Text = Convert.ToString(employee.Ssn);


            fnameTxt.Text = Convert.ToString(employee.Fname);
            lnameTxt.Text = Convert.ToString(employee.Lname);
            PositTxt.Text = Convert.ToString(employee.Position);
            if (employee.Gender.ToLower() == "female")
            {
                FemaleRD.Checked = true;
            }
            else
            {
                MaleRD.Checked = true;
            }
            dtp_bday.Text = Convert.ToString(employee.BirthDay);
            AirCombo.Text = Convert.ToString(employee.AirId);
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            //string ssn = newSSN.Text.Trim();
            string oldSsn = newSsnTxt.Text.Trim();
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


            string query = " UPDATE Employee SET SSN=@id,Fname=@first,Lname=@last,position=@posit,Gender=@gend,Brithday=@bday,Air_ID=@airId WHERE SSN =@oldSsn ";


            if (oldSsn != "" && Fname != "" && position != "" && gender != "" && airId != "")
            {
                try
                {
                    string connection = ConnectionToDB.ConnectionString;
                    SqlConnection sqlConnection = new SqlConnection(connection);
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlConnection.Open();

                    sqlCommand.Parameters.AddWithValue("@id", oldSsn);
                    sqlCommand.Parameters.AddWithValue("@first", Fname);
                    sqlCommand.Parameters.AddWithValue("@last", Lname);
                    sqlCommand.Parameters.AddWithValue("@posit", position);
                    sqlCommand.Parameters.AddWithValue("@gend", gender);
                    sqlCommand.Parameters.AddWithValue("@bday", BirthDay);
                    sqlCommand.Parameters.AddWithValue("@airId", airId);
                    sqlCommand.Parameters.AddWithValue("@oldSsn", originalSSN);

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

        private void UpdateEmployees_Load(object sender, EventArgs e)
        {

        }
    }

}
