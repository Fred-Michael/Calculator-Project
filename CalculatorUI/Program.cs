using CalculatorClassLibrary;
using System;
using System.Windows.Forms;

namespace CalculatorUI
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Config.Initialize();
            IOperations Calculate = Config.Linker;
            Application.Run(new Result(Calculate));

            Config.Uninitiate();
        }
    }
}