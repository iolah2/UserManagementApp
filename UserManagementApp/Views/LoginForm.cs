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
    public partial class LoginForm : Form
    {
        readonly ILogin repository;
        public LoginForm(ILogin repository)
        {
            InitializeComponent();
            this.repository = repository;
            if(repository.IsUserListEmpty())
            {
                MessageBox.Show("Az adatbázisban nincs felhasználó!\nAz alkalmazás leáll!");
                Close();                
            }
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
#if DEBUG
            UserDataListForm<User> usersForm = new UserDataListForm<User>(repository as IRepository<User>)
            {
                StartPosition = FormStartPosition.CenterParent
            };
            usersForm.Show();
#else
            try
            {                
                if ((userNameTB.Text ?? "") != "" && (passwordTB.Text ?? "") != "")
                {
                    if (repository.Login(userNameTB.Text, passwordTB.Text))
                    {
                        MessageBox.Show("Sikeres belépés!");
                        UserDataList<User> usersForm = new UserDataList<User>(repository as IRepository<User>)
                        {
                            StartPosition = FormStartPosition.CenterParent
                        };
                        usersForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Bejelentkezés sikertelen!\nKérem adjon meg helyes felhasználónevet és jelszót!");
                        passwordTB.Text = userNameTB.Text = "";
                    }
                }
                else MessageBox.Show("Felhasználónév és jelszó megadása kötelező!");
            }
            catch(NullReferenceException ex)
            {
                MessageBox.Show("Hiba a beléptetés folyamata során!");
            }            
        
        
#endif
        }
    }
    }
