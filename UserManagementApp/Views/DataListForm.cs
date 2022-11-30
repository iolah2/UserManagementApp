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
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                (repository as IExport).ExportDataList(filePath: saveFileDialog.FileName);
            }
        }
    }
}
