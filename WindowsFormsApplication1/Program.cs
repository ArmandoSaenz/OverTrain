using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing.Printing;
namespace WindowsFormsApplication1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Process[] processes = Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName);
            if (processes.Length > 1)
            {
                MessageBox.Show("EL SISTEMA YA ESTA ABIERTO", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            if (String.IsNullOrEmpty(WindowsFormsApplication1.Properties.Settings.Default.TicketPrinter) || String.IsNullOrWhiteSpace(WindowsFormsApplication1.Properties.Settings.Default.TicketPrinter))
            {
                PrinterSettings printer = new PrinterSettings();
                WindowsFormsApplication1.Properties.Settings.Default.TicketPrinter = printer.PrinterName;
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Inicio());
        }
    }
}
