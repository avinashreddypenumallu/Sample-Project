using System;
using System.Windows.Forms;
using System.Configuration;
using RNS.Consultant.ManagementSystem.UIForms.EmployeeManagement;
using System.Text;
using RNS.Consultant.ManagementSystem.UI_Forms;

namespace RNS.Consultant.ManagementSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (Convert.ToBoolean(ConfigurationManager.AppSettings["IsNotTestMode"]))
                Application.Run(new EmployeeRegistration());
            else
                Application.Run(new Test());


        }
    }
}
