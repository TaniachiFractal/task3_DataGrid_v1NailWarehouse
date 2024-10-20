using System;
using System.Windows.Forms;
using task3_DataGrid_v1NailWarehouse.Forms;
using task3_DataGrid_v1NailWarehouse.Memory;

namespace task3_DataGrid_v1NailWarehouse
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var storage = new MemoryNailStorage();
            var manager = new NailManagers.NailManager(storage);
            Application.Run(new MainForm(manager));
        }
    }
}
