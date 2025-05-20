using Airplane.AirLine;
using Airplane.AirLine_Address;
using Airplane.AirLine_Phones;
using Airplane.AirPlane_Form;
using Airplane.AirplaneRoute;
using Airplane.EmployeeAddress;
using Airplane.Route;
using System.Windows.Forms.Design;


namespace Airplane
{
    internal static class Program
    {

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            Application.Run(new AirplaneRouteForm());
            Application.Run(new AirLinePhonesForm());
            Application.Run(new AirlineAddForm());
            Application.Run(new Routes());
            Application.Run(new Airline());
            Application.Run(new AirPlanecs());
            Application.Run(new Employees());
            Application.Run(new EmpAddForm());

        }
    }
}