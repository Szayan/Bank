using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    internal static class Program
    {
        // The main entry point for the application
        [STAThread]
        static void Main()
        {
            // Enable visual styles for the application
            Application.EnableVisualStyles();
            // Set the default text rendering to be compatible with the application
            Application.SetCompatibleTextRenderingDefault(false);
            // Run the main form of the application
            Application.Run(new Form1());
        }
    }