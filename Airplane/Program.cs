using System.Windows.Forms.Design;
using Airplane.AirLine;
using Airplane.AirLine_Address;
using Airplane.AirLine_Phones;
using Airplane.AirPlane_Form;
using Airplane.AirplaneRoute;
using Airplane.EmployeeAddress;
using Airplane.LogIn;
using Airplane.Main;
using Airplane.Route;


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

            
            Application.Run(new LogInForm());
        }
    }
}