using System;
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
        /// Edit item is ActItem in repository
        /// </summary>        
        /// <param name="repository"></param>
        public DetailForm(IRepository<User> repository)
        {
            InitializeComponent();            
            this.userBindingSource.DataSource = repository.ActItem;          
            this.repository = repository as UserRepository;
            repository.ActItem.StartEdit();
            //Set false for can use tabindex
            //https://supportcenter.devexpress.com/Ticket/Details/T403822/tabindex-for-controls-in-layoutcontrol-is-uncontrollable
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            repository.ActItem.ResetUserOld();
            Close();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string errorMessage = repository.Update();
                if ((errorMessage ?? "") == "")
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
                MessageBox.Show($"Felhasználó ({repository.ActItem}) mentése sikertelen!\n{ex.Message}");
            }
        }
    }
}
