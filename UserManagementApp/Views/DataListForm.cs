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
    public partial class DataListForm<T> : Form where T : class
    {
        IRepository<T> repository;
        public DataListForm(IRepository<T> repository)
        {
            this.repository = repository;
            InitializeComponent();
            usersDGV.DataSource = repository.GetList();
            var form = new UserDataListForm<User>(repository as IRepository<User>);
            form.Show();
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                (repository as IExport).ExportDataList(filePath: saveFileDialog.FileName);
            }
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            if(usersDGV.SelectedRows != null)
            {
                User user = usersDGV.SelectedRows[0].DataBoundItem as User;
                DetailForm<User> detailForm = new DetailForm<User>(user, repository as UserRepository);
                detailForm.StartPosition = FormStartPosition.CenterParent;
                //detailForm.TopMost = true;
                detailForm.ShowDialog();
            }
        }
    }
}
