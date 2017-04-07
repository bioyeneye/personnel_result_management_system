using System;
using System.Linq;
using System.Windows.Forms;
using PersonalResultManagement.UI;
using PersonalResultManagement.UI.Authentication;

namespace PersonalResultManagement
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
            Application.Run(new Login());
        }
    }
}