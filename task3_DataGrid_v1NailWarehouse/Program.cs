using System;
using System.Windows.Forms;
using task3_DataGrid_v1NailWarehouse.Forms;

namespace task3_DataGrid_v1NailWarehouse
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
            Application.Run(new MainForm());
        }
    }
}
