using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserManagementApp.Repositories;

namespace UserManagementApp
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
            try
            {
            Application.Run(new Views.LoginForm(new UserRepository()));
            }
            catch (Exception ex)
            {
                MessageBox.Show("A(z) User management program leáll!\n" + ex.Message);
            }
        }
    }
}
