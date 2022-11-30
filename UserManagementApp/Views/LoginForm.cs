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
            this.repository = repository;// new UserRepository();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {

            try
            {
                //Todo: Allow password empty or need passwordTB.Text condition too?
            if((userNameTB.Text?? "")!="")
            {
                if(repository.Login(userNameTB.Text, passwordTB.Text))
                {
                    MessageBox.Show("Login success!");
                    DataListForm<User> usersForm = new DataListForm<User>(repository as IRepository<User>);
                    usersForm.Show();
                }
                else
                {
                    MessageBox.Show("Login failed!");
                    passwordTB.Text = userNameTB.Text = "";
                }
            }
            }
            catch (Exception)
            {

                throw;
            }
            //try user + password testing
            //If Ok -> message with success and go to nnext form
            //Else message unsuccess
        }
    }
}
