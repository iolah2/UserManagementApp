﻿using System;
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
    public partial class DetailForm<T> : Form where T : class
    {
        private T user;
        private IRepository<T> repository;

        public DetailForm(T user, IRepository<T> repository) 
        {
            InitializeComponent();            
            this.userBindingSource.DataSource = user;
            this.user = user;
            this.repository = repository;

        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string errorMessage;
                if ((errorMessage = repository.Update(user)) == null)
                {
                    MessageBox.Show("Felhasználó mentése sikeres!");
                }
                else MessageBox.Show($"Felhasználó adatok validálási hiba!\n{errorMessage}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Felhasználó ({user}) mentése sikertelen!\n{ex.Message}");
            }
        }
    }
}
