using Airplane.AirLine;
using Airplane.AirLine_Address;
using Airplane.AirLine_Phones;
using Airplane.AirPlane_Form;
using Airplane.AirplaneRoute;
using Airplane.EmployeeAddress;
using Airplane.LogIn;
using Airplane.Route;

namespace Airplane.Main
{
    public partial class MainForm : Form
    {
        private string currentSsn;
        private string currentFname;
        private string currentLname;
        private string currentPosition;
        public MainForm(string ssn, string fname, string lname, string position)
        {
            InitializeComponent();
            currentSsn = ssn;
            currentFname = fname;
            currentLname = lname;
            currentPosition = position;

            label1.Text = $"Welcome {fname} {lname} ({position})";
        }



        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void btnAirline_Click_1(object sender, EventArgs e)
        {
            Airline form = new Airline();
            form.ShowDialog();
        }

        private void btnAirlinePhones_Click_1(object sender, EventArgs e)
        {
            AirLinePhonesForm form = new AirLinePhonesForm();
            form.ShowDialog();
        }

        private void btnAirlineAdd_Click_1(object sender, EventArgs e)
        {
            AirlineAddForm form = new AirlineAddForm();
            form.ShowDialog();
        }

        private void btnRoutes_Click_1(object sender, EventArgs e)
        {
            Routes form = new Routes();
            form.ShowDialog();
        }

        private void btnAirplanes_Click_1(object sender, EventArgs e)
        {
            AirPlanecs form = new AirPlanecs();
            form.ShowDialog();
        }

        private void btnEmployees_Click_1(object sender, EventArgs e)
        {
            Employees form = new Employees();
            form.ShowDialog();
        }

        private void btnEmpAdd_Click_1(object sender, EventArgs e)
        {
            EmpAddForm form = new EmpAddForm();
            form.ShowDialog();
        }

        private void btnAirplaneRoute_Click_1(object sender, EventArgs e)
        {
            AirplaneRouteForm form = new AirplaneRouteForm();
            form.ShowDialog();
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            this.Close();
            LogInForm login = new LogInForm();
            login.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
