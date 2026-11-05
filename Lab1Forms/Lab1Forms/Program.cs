using System;
using System.Windows.Forms;

namespace Lab1Forms
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // The program starts on the login form
            Application.Run(new LoginForm());
        }
    }
}
