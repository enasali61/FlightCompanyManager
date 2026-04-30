using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Airplane.Main;
using Microsoft.Data.SqlClient;

namespace Airplane.LogIn
{
    public partial class LogInForm : Form
    {

        public LogInForm()
        {
            InitializeComponent();
        }



        private void LogInbutton_Click(object sender, EventArgs e)
        {
            // 1. Get input and trim spaces
            string fname = fnameTxt.Text.Trim();
            string lname = lnameTxt.Text.Trim();
            string ssn = ssnTxt.Text.Trim();
            string position0 = PositTxt.Text.Trim();

            // 2. Validate empty fields
            if (string.IsNullOrWhiteSpace(fname) || string.IsNullOrWhiteSpace(lname) || string.IsNullOrWhiteSpace(ssn))
            {
                MessageBox.Show("Please enter first name, last name, and SSN.", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Stop here – do NOT go further
            }

            // 3. Now check database for valid credentials
            string query = "SELECT SSN, Fname, Lname, position FROM Employee WHERE Fname = @fname AND Lname = @lname AND SSN = @ssn";

            using (SqlConnection conn = new SqlConnection(ConnectionToDB.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@fname", fname);
                cmd.Parameters.AddWithValue("@lname", lname);
                cmd.Parameters.AddWithValue("@ssn", ssn);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        // 4. Login successful – get employee details
                        string empSsn = reader["SSN"].ToString();
                        string empFname = reader["Fname"].ToString();
                        string empLname = reader["Lname"].ToString();
                        string position = reader["position"].ToString();

                        // 5. ONLY NOW create and show MainForm
                        MainForm main = new MainForm(empSsn, empFname, empLname, position);
                        main.Show();
                        this.Hide(); // Hide login form
                    }
                    else
                    {
                        // 6. Login failed – show error and stay on login form
                        MessageBox.Show("Invalid first name, last name, or SSN.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {

        }
    }
}

