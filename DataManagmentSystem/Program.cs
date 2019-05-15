using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;

namespace DataManagmentSystem
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

            var loginForm = new Login();
            if (loginForm.ShowDialog() != DialogResult.OK)
            {
                MessageBox.Show(@"登陆失败，请联系管理员");
            }
            else
            {
                Application.Run(new MainForm(loginForm.UserName));
            }
        }
    }
}
