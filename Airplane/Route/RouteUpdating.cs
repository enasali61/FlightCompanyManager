using Microsoft.Data.SqlClient;

namespace Airplane.Route
{
    public partial class RouteUpdating : Form
    {
        private string originalId;
        private Routes mainform;
        public RouteUpdating(Route route, Routes form)
        {
            InitializeComponent();
            mainform = form;


            routeIdTXT.Text = Convert.ToString(route.Routeid);
            distanceTXT.Text = Convert.ToString(route.Distance);
            destinationTXT.Text = Convert.ToString(route.Distenation);
            originalId = Convert.ToString(route.Routeid);
        }

        private void updateBtn_Click(object sender, EventArgs e)
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
                    string query = "UPDATE Route SET RouteId=@oldid,Distance=@dista,Destination=@diste WHERE RouteId =@id";
                    sqlConnection.Open();

                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);


                    sqlCommand.Parameters.AddWithValue("@oldid", Routeid);
                    sqlCommand.Parameters.AddWithValue("@dista", Distance);
                    sqlCommand.Parameters.AddWithValue("@diste", Distenation);
                    sqlCommand.Parameters.AddWithValue("@id", originalId);

                    int rows = sqlCommand.ExecuteNonQuery();

                    MessageBox.Show($"{rows} row Succesfully Updatted");
                    mainform.loadData();     
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
