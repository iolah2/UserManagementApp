using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserManagementApp.Models;
using UserManagementApp.Repositories;

namespace UserManagementApp.Views
{
    public partial class DetailForm : Form //<T> : Form where T : class
    {
        //private T user;
        private readonly /*IRepository<T>*/UserRepository repository;

        /// <summary>
        /// Edit item is AktItem in repository
        /// </summary>        
        /// <param name="repository"></param>
        public DetailForm(IRepository<User> repository) /*T user, IRepository<T>*/
        {
            InitializeComponent();            
            this.userBindingSource.DataSource = repository.AktItem;
            //this.user = user;            
            this.repository = repository as UserRepository;
            repository.AktItem.StartEdit();
            //Set false for can use tabindex
            //https://supportcenter.devexpress.com/Ticket/Details/T403822/tabindex-for-controls-in-layoutcontrol-is-uncontrollable
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            repository.AktItem.ResetUserOld();
            Close();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string errorMessage;
                if ((errorMessage = repository.Update()) == null)
                {
                    MessageBox.Show("Felhasználó mentése sikeres!");
                    Close();
                }
                else
                {
                    MessageBox.Show($"Felhasználó adatok validálási hiba!\n{errorMessage}");                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Felhasználó ({repository.AktItem}) mentése sikertelen!\n{ex.Message}");
            }
        }
    }
}
