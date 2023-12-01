using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManagementApp;

namespace TaskManagement1
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
            //Application.Run(new Tasks());
            //Application.Run(new Register());
            //Application.Run(new AI()); 
            //Application.Run(new Calendar());
            //Application.Run(new Project());
            //Application.Run(new QA1());
            //Application.Run(new Events());
            //Application.Run(new Dashboard());
            //Application.Run(new Files());
            //Application.Run(new UserData());
            Application.Run(new Login());
            //Application.Run(new Methods());
            //Application.Run(new Invitation());
        }
    }
}
