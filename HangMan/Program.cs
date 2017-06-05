using System;
using System.Windows.Forms;

namespace HangMan
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
            Application.Run(new frmHangman());
            //Application.Run(new MainForm());
        }
    }
}
