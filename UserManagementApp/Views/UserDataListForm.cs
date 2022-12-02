using DevExpress.XtraEditors;
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
    public partial class UserDataListForm<T> : Form where T : class
    {
        readonly IRepository<T> repository;
        public UserDataListForm(IRepository<T> repository)
        {
            this.repository = repository;
            InitializeComponent();
            userGridControl.DataSource = repository.GetList();            
        }

        private void ModifyBtn_Click(object sender, EventArgs e)
        {
            if (userListGridView.SelectedRowsCount != 0)
            {
                User user = userListGridView.GetRow(userListGridView.FocusedRowHandle) as User;

                IRepository<User> repo = repository as UserRepository;
                if (repo.SetActItemById(user.ID))
                {
                    DetailForm/*<User>*/ detailForm = new DetailForm/*<User>*/(repo)//User and generic escape
                    {
                        StartPosition = FormStartPosition.CenterParent,
                        TopMost = true
                    };
                    detailForm.ShowDialog();
                    userListGridView.RefreshData();
                }
                else MessageBox.Show($"A választott felhasználó {user} nem található a felhasználók listájában!");
            }
        }

        private void XMLExportBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    (repository as IExport).ExportDataList(filePath: saveFileDialog.FileName);
                    MessageBox.Show($"XML export sikeres ({saveFileDialog.FileName})");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"XML export sikertelen!\n{ex.Message}");
            }
        }

        private void SearchText_EditValueChanged(object sender, EventArgs e)
        {
            if ((sender as TextEdit).Text.Length >= 3)
            {
                //https://supportcenter.devexpress.com/Ticket/Details/Q525435/gridcontrol-grid-view-filtering-by-a-textedit
                userListGridView.FindFilterText = (sender as TextEdit).Text;                
            }
            else if(userListGridView.FindFilterText != "")
            {
                userListGridView.FindFilterText = "";
            }
        }        
    }
}
