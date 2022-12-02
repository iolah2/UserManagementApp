
namespace UserManagementApp.Views
{
    partial class UserDataListForm<T>
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
            this.userGridControl = new DevExpress.XtraGrid.GridControl();
            this.userListGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPassword = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateOfBirth = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPlaceOfBirth = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCityOfAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.modifyBtn = new DevExpress.XtraEditors.SimpleButton();
            this.exportBtn = new DevExpress.XtraEditors.SimpleButton();
            this.saveFileDialog = new DevExpress.XtraEditors.XtraSaveFileDialog(this.components);
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.stackPanel1 = new DevExpress.Utils.Layout.StackPanel();
            ((System.ComponentModel.ISupportInitialize)(this.userGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userListGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel1)).BeginInit();
            this.stackPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // userGridControl
            // 
            this.userGridControl.DataSource = typeof(UserManagementApp.Models.User);
            this.userGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userGridControl.Location = new System.Drawing.Point(0, 0);
            this.userGridControl.MainView = this.userListGridView;
            this.userGridControl.Name = "userGridControl";
            this.userGridControl.Size = new System.Drawing.Size(660, 184);
            this.userGridControl.TabIndex = 0;
            this.userGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.userListGridView,
            this.gridView1});
            // 
            // userListGridView
            // 
            this.userListGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8});
            this.userListGridView.GridControl = this.userGridControl;
            this.userListGridView.Name = "userListGridView";
            this.userListGridView.OptionsBehavior.Editable = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ID";
            this.gridColumn1.FieldName = "ID";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 62;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Felhasználó";
            this.gridColumn2.FieldName = "UserName";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 131;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Jelszó";
            this.gridColumn3.FieldName = "Password";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 121;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Családnév";
            this.gridColumn4.FieldName = "LastName";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 152;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Keresztnév";
            this.gridColumn5.FieldName = "FirstName";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 146;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Szül. idő";
            this.gridColumn6.FieldName = "DateOfBirth";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            this.gridColumn6.Width = 91;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Szül. hely";
            this.gridColumn7.FieldName = "PlaceOfBirth";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            this.gridColumn7.Width = 181;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Lakhely";
            this.gridColumn8.FieldName = "CityOfAddress";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 7;
            this.gridColumn8.Width = 219;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colUserName,
            this.colPassword,
            this.colLastName,
            this.colFirstName,
            this.colDateOfBirth,
            this.colPlaceOfBirth,
            this.colCityOfAddress});
            this.gridView1.GridControl = this.userGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colID
            // 
            this.colID.Caption = "Azonosító";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            // 
            // colUserName
            // 
            this.colUserName.Caption = "Felhasználónév";
            this.colUserName.FieldName = "UserName";
            this.colUserName.Name = "colUserName";
            // 
            // colPassword
            // 
            this.colPassword.Caption = "Jelszó";
            this.colPassword.FieldName = "Password";
            this.colPassword.Name = "colPassword";
            // 
            // colLastName
            // 
            this.colLastName.Caption = "Családi név";
            this.colLastName.FieldName = "LastName";
            this.colLastName.Name = "colLastName";
            // 
            // colFirstName
            // 
            this.colFirstName.Caption = "Keresztnév";
            this.colFirstName.FieldName = "FirstName";
            this.colFirstName.Name = "colFirstName";
            // 
            // colDateOfBirth
            // 
            this.colDateOfBirth.Caption = "Szül. idő";
            this.colDateOfBirth.FieldName = "DateOfBirth";
            this.colDateOfBirth.Name = "colDateOfBirth";
            // 
            // colPlaceOfBirth
            // 
            this.colPlaceOfBirth.Caption = "Szül. hely";
            this.colPlaceOfBirth.FieldName = "PlaceOfBirth";
            this.colPlaceOfBirth.Name = "colPlaceOfBirth";
            // 
            // colCityOfAddress
            // 
            this.colCityOfAddress.Caption = "Lakhely (Város)";
            this.colCityOfAddress.FieldName = "CityOfAddress";
            this.colCityOfAddress.Name = "colCityOfAddress";
            // 
            // modifyBtn
            // 
            this.modifyBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.modifyBtn.Appearance.Options.UseFont = true;
            this.modifyBtn.Location = new System.Drawing.Point(301, 2);
            this.modifyBtn.Margin = new System.Windows.Forms.Padding(50, 3, 3, 3);
            this.modifyBtn.Name = "modifyBtn";
            this.modifyBtn.Size = new System.Drawing.Size(85, 23);
            this.modifyBtn.TabIndex = 1;
            this.modifyBtn.Text = "Módosítás";
            this.modifyBtn.Click += new System.EventHandler(this.ModifyBtn_Click);
            // 
            // exportBtn
            // 
            this.exportBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.exportBtn.Appearance.Options.UseFont = true;
            this.exportBtn.Location = new System.Drawing.Point(459, 2);
            this.exportBtn.Margin = new System.Windows.Forms.Padding(70, 3, 30, 3);
            this.exportBtn.Name = "exportBtn";
            this.exportBtn.Size = new System.Drawing.Size(91, 23);
            this.exportBtn.TabIndex = 2;
            this.exportBtn.Text = "XML Export";
            this.exportBtn.Click += new System.EventHandler(this.XMLExportBtn_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "XML-File|*.xml";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(105, 4);
            this.textEdit1.Margin = new System.Windows.Forms.Padding(13, 3, 13, 3);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(133, 20);
            this.textEdit1.TabIndex = 3;
            this.textEdit1.EditValueChanged += new System.EventHandler(this.SearchText_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(30, 4);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(59, 19);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Keresés:";
            // 
            // stackPanel1
            // 
            this.stackPanel1.Controls.Add(this.labelControl1);
            this.stackPanel1.Controls.Add(this.textEdit1);
            this.stackPanel1.Controls.Add(this.modifyBtn);
            this.stackPanel1.Controls.Add(this.exportBtn);
            this.stackPanel1.Location = new System.Drawing.Point(0, 2);
            this.stackPanel1.Name = "stackPanel1";
            this.stackPanel1.Size = new System.Drawing.Size(660, 28);
            this.stackPanel1.TabIndex = 5;
            // 
            // UserDataListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 184);
            this.Controls.Add(this.stackPanel1);
            this.Controls.Add(this.userGridControl);
            this.Name = "UserDataListForm";
            this.Text = "Felhasználók";
            ((System.ComponentModel.ISupportInitialize)(this.userGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userListGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel1)).EndInit();
            this.stackPanel1.ResumeLayout(false);
            this.stackPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl userGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView userListGridView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraEditors.SimpleButton modifyBtn;
        private DevExpress.XtraEditors.SimpleButton exportBtn;
        private DevExpress.XtraEditors.XtraSaveFileDialog saveFileDialog;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colUserName;
        private DevExpress.XtraGrid.Columns.GridColumn colPassword;
        private DevExpress.XtraGrid.Columns.GridColumn colLastName;
        private DevExpress.XtraGrid.Columns.GridColumn colFirstName;
        private DevExpress.XtraGrid.Columns.GridColumn colDateOfBirth;
        private DevExpress.XtraGrid.Columns.GridColumn colPlaceOfBirth;
        private DevExpress.XtraGrid.Columns.GridColumn colCityOfAddress;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.Utils.Layout.StackPanel stackPanel1;
    }
}