
namespace UserManagementApp.Views
{
    partial class DataListForm<T>
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.searchControl1 = new DevExpress.XtraEditors.SearchControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.saveFileDialog = new DevExpress.XtraEditors.XtraSaveFileDialog(this.components);
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.DataListFormlayoutControl1ConvertedLayout = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.simpleButton2item = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleButton1item = new DevExpress.XtraLayout.LayoutControlItem();
            this.searchControl1item = new DevExpress.XtraLayout.LayoutControlItem();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersDGVitem = new DevExpress.XtraLayout.LayoutControlItem();
            this.cityOfAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placeOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataListFormlayoutControl1ConvertedLayout)).BeginInit();
            this.DataListFormlayoutControl1ConvertedLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleButton2item)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleButton1item)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1item)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDGVitem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // searchControl1
            // 
            this.searchControl1.Location = new System.Drawing.Point(12, 12);
            this.searchControl1.Name = "searchControl1";
            this.searchControl1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.searchControl1.Size = new System.Drawing.Size(341, 20);
            this.searchControl1.StyleController = this.DataListFormlayoutControl1ConvertedLayout;
            this.searchControl1.TabIndex = 2;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(474, 12);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(375, 22);
            this.simpleButton1.StyleController = this.DataListFormlayoutControl1ConvertedLayout;
            this.simpleButton1.TabIndex = 3;
            this.simpleButton1.Text = "XML Export";
            this.simpleButton1.Click += new System.EventHandler(this.exportBtn_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileName = "xtraSaveFileDialog1";
            this.saveFileDialog.Filter = "XML-File | *.xml";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(357, 12);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(113, 22);
            this.simpleButton2.StyleController = this.DataListFormlayoutControl1ConvertedLayout;
            this.simpleButton2.TabIndex = 4;
            this.simpleButton2.Text = "Módosítás";
            this.simpleButton2.Click += new System.EventHandler(this.modifyButton_Click);
            // 
            // DataListFormlayoutControl1ConvertedLayout
            // 
            this.DataListFormlayoutControl1ConvertedLayout.Controls.Add(this.simpleButton2);
            this.DataListFormlayoutControl1ConvertedLayout.Controls.Add(this.simpleButton1);
            this.DataListFormlayoutControl1ConvertedLayout.Controls.Add(this.searchControl1);
            this.DataListFormlayoutControl1ConvertedLayout.Controls.Add(this.usersDGV);
            this.DataListFormlayoutControl1ConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataListFormlayoutControl1ConvertedLayout.Location = new System.Drawing.Point(0, 0);
            this.DataListFormlayoutControl1ConvertedLayout.Name = "DataListFormlayoutControl1ConvertedLayout";
            this.DataListFormlayoutControl1ConvertedLayout.Root = this.layoutControlGroup1;
            this.DataListFormlayoutControl1ConvertedLayout.Size = new System.Drawing.Size(861, 384);
            this.DataListFormlayoutControl1ConvertedLayout.TabIndex = 5;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.simpleButton2item,
            this.simpleButton1item,
            this.searchControl1item,
            this.usersDGVitem});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(861, 384);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // simpleButton2item
            // 
            this.simpleButton2item.Control = this.simpleButton2;
            this.simpleButton2item.Location = new System.Drawing.Point(345, 0);
            this.simpleButton2item.Name = "simpleButton2item";
            this.simpleButton2item.Size = new System.Drawing.Size(117, 26);
            this.simpleButton2item.TextSize = new System.Drawing.Size(0, 0);
            this.simpleButton2item.TextVisible = false;
            // 
            // simpleButton1item
            // 
            this.simpleButton1item.Control = this.simpleButton1;
            this.simpleButton1item.Location = new System.Drawing.Point(462, 0);
            this.simpleButton1item.Name = "simpleButton1item";
            this.simpleButton1item.Size = new System.Drawing.Size(379, 26);
            this.simpleButton1item.TextSize = new System.Drawing.Size(0, 0);
            this.simpleButton1item.TextVisible = false;
            // 
            // searchControl1item
            // 
            this.searchControl1item.Control = this.searchControl1;
            this.searchControl1item.Location = new System.Drawing.Point(0, 0);
            this.searchControl1item.Name = "searchControl1item";
            this.searchControl1item.Size = new System.Drawing.Size(345, 26);
            this.searchControl1item.TextSize = new System.Drawing.Size(0, 0);
            this.searchControl1item.TextVisible = false;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(UserManagementApp.Models.User);
            // 
            // usersDGVitem
            // 
            this.usersDGVitem.Control = this.usersDGV;
            this.usersDGVitem.Location = new System.Drawing.Point(0, 26);
            this.usersDGVitem.Name = "usersDGVitem";
            this.usersDGVitem.Size = new System.Drawing.Size(841, 338);
            this.usersDGVitem.TextSize = new System.Drawing.Size(66, 13);
            // 
            // cityOfAddressDataGridViewTextBoxColumn
            // 
            this.cityOfAddressDataGridViewTextBoxColumn.DataPropertyName = "CityOfAddress";
            this.cityOfAddressDataGridViewTextBoxColumn.HeaderText = "CityOfAddress";
            this.cityOfAddressDataGridViewTextBoxColumn.Name = "cityOfAddressDataGridViewTextBoxColumn";
            // 
            // placeOfBirthDataGridViewTextBoxColumn
            // 
            this.placeOfBirthDataGridViewTextBoxColumn.DataPropertyName = "PlaceOfBirth";
            this.placeOfBirthDataGridViewTextBoxColumn.HeaderText = "PlaceOfBirth";
            this.placeOfBirthDataGridViewTextBoxColumn.Name = "placeOfBirthDataGridViewTextBoxColumn";
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "UserName";
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // usersDGV
            // 
            this.usersDGV.AllowUserToAddRows = false;
            this.usersDGV.AllowUserToDeleteRows = false;
            this.usersDGV.AutoGenerateColumns = false;
            this.usersDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.dateOfBirthDataGridViewTextBoxColumn,
            this.placeOfBirthDataGridViewTextBoxColumn,
            this.cityOfAddressDataGridViewTextBoxColumn});
            this.usersDGV.DataSource = this.userBindingSource;
            this.usersDGV.Location = new System.Drawing.Point(90, 38);
            this.usersDGV.MultiSelect = false;
            this.usersDGV.Name = "usersDGV";
            this.usersDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.usersDGV.Size = new System.Drawing.Size(759, 334);
            this.usersDGV.TabIndex = 1;
            // 
            // DataListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 384);
            this.Controls.Add(this.DataListFormlayoutControl1ConvertedLayout);
            this.Name = "DataListForm";
            this.Text = "SearchForm";
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataListFormlayoutControl1ConvertedLayout)).EndInit();
            this.DataListFormlayoutControl1ConvertedLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleButton2item)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleButton1item)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1item)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDGVitem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource userBindingSource;
        private DevExpress.XtraEditors.SearchControl searchControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.XtraSaveFileDialog saveFileDialog;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraLayout.LayoutControl DataListFormlayoutControl1ConvertedLayout;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem simpleButton2item;
        private DevExpress.XtraLayout.LayoutControlItem simpleButton1item;
        private DevExpress.XtraLayout.LayoutControlItem searchControl1item;
        private System.Windows.Forms.DataGridView usersDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placeOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityOfAddressDataGridViewTextBoxColumn;
        private DevExpress.XtraLayout.LayoutControlItem usersDGVitem;
    }
}