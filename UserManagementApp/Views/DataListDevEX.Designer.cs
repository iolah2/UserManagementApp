
namespace UserManagementApp.Views
{
    partial class GridControlDevEX<T>
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
            this.layoutView1 = new DevExpress.XtraGrid.Views.Layout.LayoutView();
            this.colID = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colID = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colUserName = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colUserName = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colPassword = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colPassword = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colLastName = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colLastName = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colFirstName = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colFirstName = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colDateOfBirth = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colDateOfBirth = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colPlaceOfBirth = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colPlaceOfBirth = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colCityOfAddress = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colCityOfAddress = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewCard1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
            this.modifyBtn = new DevExpress.XtraEditors.SimpleButton();
            this.exportBtn = new DevExpress.XtraEditors.SimpleButton();
            this.saveFileDialog = new DevExpress.XtraEditors.XtraSaveFileDialog(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.userGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userListGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colUserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colLastName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colFirstName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colDateOfBirth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colPlaceOfBirth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colCityOfAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).BeginInit();
            this.SuspendLayout();
            // 
            // userGridControl
            // 
            this.userGridControl.DataSource = typeof(UserManagementApp.Models.User);
            this.userGridControl.Location = new System.Drawing.Point(12, 27);
            this.userGridControl.MainView = this.userListGridView;
            this.userGridControl.Name = "userGridControl";
            this.userGridControl.Size = new System.Drawing.Size(706, 300);
            this.userGridControl.TabIndex = 0;
            this.userGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.userListGridView,
            this.layoutView1});
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
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "ID";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.FieldName = "UserName";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.FieldName = "Password";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.FieldName = "LastName";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.FieldName = "FirstName";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // gridColumn6
            // 
            this.gridColumn6.FieldName = "DateOfBirth";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            // 
            // gridColumn7
            // 
            this.gridColumn7.FieldName = "PlaceOfBirth";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            // 
            // gridColumn8
            // 
            this.gridColumn8.FieldName = "CityOfAddress";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 7;
            // 
            // layoutView1
            // 
            this.layoutView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.LayoutViewColumn[] {
            this.colID,
            this.colUserName,
            this.colPassword,
            this.colLastName,
            this.colFirstName,
            this.colDateOfBirth,
            this.colPlaceOfBirth,
            this.colCityOfAddress});
            this.layoutView1.GridControl = this.userGridControl;
            this.layoutView1.Name = "layoutView1";
            this.layoutView1.TemplateCard = this.layoutViewCard1;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.LayoutViewField = this.layoutViewField_colID;
            this.colID.Name = "colID";
            // 
            // layoutViewField_colID
            // 
            this.layoutViewField_colID.EditorPreferredWidth = 115;
            this.layoutViewField_colID.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_colID.Name = "layoutViewField_colID";
            this.layoutViewField_colID.Size = new System.Drawing.Size(211, 24);
            this.layoutViewField_colID.TextSize = new System.Drawing.Size(80, 13);
            // 
            // colUserName
            // 
            this.colUserName.FieldName = "UserName";
            this.colUserName.LayoutViewField = this.layoutViewField_colUserName;
            this.colUserName.Name = "colUserName";
            // 
            // layoutViewField_colUserName
            // 
            this.layoutViewField_colUserName.EditorPreferredWidth = 115;
            this.layoutViewField_colUserName.Location = new System.Drawing.Point(0, 24);
            this.layoutViewField_colUserName.Name = "layoutViewField_colUserName";
            this.layoutViewField_colUserName.Size = new System.Drawing.Size(211, 24);
            this.layoutViewField_colUserName.TextSize = new System.Drawing.Size(80, 13);
            // 
            // colPassword
            // 
            this.colPassword.FieldName = "Password";
            this.colPassword.LayoutViewField = this.layoutViewField_colPassword;
            this.colPassword.Name = "colPassword";
            // 
            // layoutViewField_colPassword
            // 
            this.layoutViewField_colPassword.EditorPreferredWidth = 115;
            this.layoutViewField_colPassword.Location = new System.Drawing.Point(0, 48);
            this.layoutViewField_colPassword.Name = "layoutViewField_colPassword";
            this.layoutViewField_colPassword.Size = new System.Drawing.Size(211, 24);
            this.layoutViewField_colPassword.TextSize = new System.Drawing.Size(80, 13);
            // 
            // colLastName
            // 
            this.colLastName.FieldName = "LastName";
            this.colLastName.LayoutViewField = this.layoutViewField_colLastName;
            this.colLastName.Name = "colLastName";
            // 
            // layoutViewField_colLastName
            // 
            this.layoutViewField_colLastName.EditorPreferredWidth = 115;
            this.layoutViewField_colLastName.Location = new System.Drawing.Point(0, 72);
            this.layoutViewField_colLastName.Name = "layoutViewField_colLastName";
            this.layoutViewField_colLastName.Size = new System.Drawing.Size(211, 24);
            this.layoutViewField_colLastName.TextSize = new System.Drawing.Size(80, 13);
            // 
            // colFirstName
            // 
            this.colFirstName.FieldName = "FirstName";
            this.colFirstName.LayoutViewField = this.layoutViewField_colFirstName;
            this.colFirstName.Name = "colFirstName";
            // 
            // layoutViewField_colFirstName
            // 
            this.layoutViewField_colFirstName.EditorPreferredWidth = 115;
            this.layoutViewField_colFirstName.Location = new System.Drawing.Point(0, 96);
            this.layoutViewField_colFirstName.Name = "layoutViewField_colFirstName";
            this.layoutViewField_colFirstName.Size = new System.Drawing.Size(211, 24);
            this.layoutViewField_colFirstName.TextSize = new System.Drawing.Size(80, 13);
            // 
            // colDateOfBirth
            // 
            this.colDateOfBirth.FieldName = "DateOfBirth";
            this.colDateOfBirth.LayoutViewField = this.layoutViewField_colDateOfBirth;
            this.colDateOfBirth.Name = "colDateOfBirth";
            // 
            // layoutViewField_colDateOfBirth
            // 
            this.layoutViewField_colDateOfBirth.EditorPreferredWidth = 115;
            this.layoutViewField_colDateOfBirth.Location = new System.Drawing.Point(0, 120);
            this.layoutViewField_colDateOfBirth.Name = "layoutViewField_colDateOfBirth";
            this.layoutViewField_colDateOfBirth.Size = new System.Drawing.Size(211, 24);
            this.layoutViewField_colDateOfBirth.TextSize = new System.Drawing.Size(80, 13);
            // 
            // colPlaceOfBirth
            // 
            this.colPlaceOfBirth.FieldName = "PlaceOfBirth";
            this.colPlaceOfBirth.LayoutViewField = this.layoutViewField_colPlaceOfBirth;
            this.colPlaceOfBirth.Name = "colPlaceOfBirth";
            // 
            // layoutViewField_colPlaceOfBirth
            // 
            this.layoutViewField_colPlaceOfBirth.EditorPreferredWidth = 115;
            this.layoutViewField_colPlaceOfBirth.Location = new System.Drawing.Point(0, 144);
            this.layoutViewField_colPlaceOfBirth.Name = "layoutViewField_colPlaceOfBirth";
            this.layoutViewField_colPlaceOfBirth.Size = new System.Drawing.Size(211, 24);
            this.layoutViewField_colPlaceOfBirth.TextSize = new System.Drawing.Size(80, 13);
            // 
            // colCityOfAddress
            // 
            this.colCityOfAddress.FieldName = "CityOfAddress";
            this.colCityOfAddress.LayoutViewField = this.layoutViewField_colCityOfAddress;
            this.colCityOfAddress.Name = "colCityOfAddress";
            // 
            // layoutViewField_colCityOfAddress
            // 
            this.layoutViewField_colCityOfAddress.EditorPreferredWidth = 115;
            this.layoutViewField_colCityOfAddress.Location = new System.Drawing.Point(0, 168);
            this.layoutViewField_colCityOfAddress.Name = "layoutViewField_colCityOfAddress";
            this.layoutViewField_colCityOfAddress.Size = new System.Drawing.Size(211, 24);
            this.layoutViewField_colCityOfAddress.TextSize = new System.Drawing.Size(80, 13);
            // 
            // layoutViewCard1
            // 
            this.layoutViewCard1.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.layoutViewCard1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_colID,
            this.layoutViewField_colUserName,
            this.layoutViewField_colPassword,
            this.layoutViewField_colLastName,
            this.layoutViewField_colFirstName,
            this.layoutViewField_colDateOfBirth,
            this.layoutViewField_colPlaceOfBirth,
            this.layoutViewField_colCityOfAddress});
            this.layoutViewCard1.Name = "layoutViewTemplateCard";
            // 
            // modifyBtn
            // 
            this.modifyBtn.Location = new System.Drawing.Point(304, 31);
            this.modifyBtn.Name = "modifyBtn";
            this.modifyBtn.Size = new System.Drawing.Size(75, 23);
            this.modifyBtn.TabIndex = 1;
            this.modifyBtn.Text = "Módosítás";
            this.modifyBtn.Click += new System.EventHandler(this.ModifyBtn_Click);
            // 
            // exportBtn
            // 
            this.exportBtn.Location = new System.Drawing.Point(409, 31);
            this.exportBtn.Name = "exportBtn";
            this.exportBtn.Size = new System.Drawing.Size(75, 23);
            this.exportBtn.TabIndex = 2;
            this.exportBtn.Text = "XML Export";
            this.exportBtn.Click += new System.EventHandler(this.XMLExportBtn_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "XML-File|*.xml";
            // 
            // GridControlDevEX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exportBtn);
            this.Controls.Add(this.modifyBtn);
            this.Controls.Add(this.userGridControl);
            this.Name = "GridControlDevEX";
            this.Text = "GridControlDevEX";
            ((System.ComponentModel.ISupportInitialize)(this.userGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userListGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colUserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colLastName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colFirstName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colDateOfBirth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colPlaceOfBirth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colCityOfAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).EndInit();
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
        private DevExpress.XtraGrid.Views.Layout.LayoutView layoutView1;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colID;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colID;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colUserName;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colUserName;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colPassword;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colPassword;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colLastName;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colLastName;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colFirstName;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colFirstName;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colDateOfBirth;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colDateOfBirth;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colPlaceOfBirth;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colPlaceOfBirth;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colCityOfAddress;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colCityOfAddress;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard1;
        private DevExpress.XtraEditors.SimpleButton modifyBtn;
        private DevExpress.XtraEditors.SimpleButton exportBtn;
        private DevExpress.XtraEditors.XtraSaveFileDialog saveFileDialog;
    }
}