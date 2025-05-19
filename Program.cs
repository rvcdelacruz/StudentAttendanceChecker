using System;
using System.Windows.Forms;

namespace StudentAttendanceChecker
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm()); // Show LoginForm first
        }
    }
}