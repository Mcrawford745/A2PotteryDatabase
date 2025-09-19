using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PotteryDBA_V1._0
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // setup the data directory path before it runs
            SetupDataDirectoryPath();
            Application.Run(new Forms.FrmLogin());
            //Application.Run(new Forms.FrmAddGuest());
        }

        private static void SetupDataDirectoryPath()
        {
            // this method changes the data directory path to the project folder instead of the
            // bin/Debug folders. This allows us to run code against the database in the project
            // folder instead of creating a new database every time a project is created.
            string debugPath = System.IO.Path.GetDirectoryName(Environment.CurrentDirectory);
            string dataDirectoryPath = System.IO.Path.GetDirectoryName(debugPath);
            AppDomain.CurrentDomain.SetData("DataDirectory", dataDirectoryPath);
        }
    }
}
