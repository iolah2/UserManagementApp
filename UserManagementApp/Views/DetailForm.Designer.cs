
namespace UserManagementApp.Views
{
    partial class DetailForm<T>
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
            System.Windows.Forms.Label userNameLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label dateOfBirthLabel;
            System.Windows.Forms.Label placeOfBirthLabel;
            System.Windows.Forms.Label cityOfAddressLabel;
            this.userNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.passwordTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.lastNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.firstNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.dateOfBirthDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.placeOfBirthTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.cityOfAddressTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            userNameLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            dateOfBirthLabel = new System.Windows.Forms.Label();
            placeOfBirthLabel = new System.Windows.Forms.Label();
            cityOfAddressLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateOfBirthDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateOfBirthDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.placeOfBirthTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityOfAddressTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Location = new System.Drawing.Point(112, 75);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new System.Drawing.Size(63, 13);
            userNameLabel.TabIndex = 3;
            userNameLabel.Text = "User Name:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(111, 109);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(56, 13);
            passwordLabel.TabIndex = 5;
            passwordLabel.Text = "Password:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(108, 147);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(61, 13);
            lastNameLabel.TabIndex = 7;
            lastNameLabel.Text = "Last Name:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(108, 173);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(60, 13);
            firstNameLabel.TabIndex = 9;
            firstNameLabel.Text = "First Name:";
            // 
            // dateOfBirthLabel
            // 
            dateOfBirthLabel.AutoSize = true;
            dateOfBirthLabel.Location = new System.Drawing.Point(112, 206);
            dateOfBirthLabel.Name = "dateOfBirthLabel";
            dateOfBirthLabel.Size = new System.Drawing.Size(71, 13);
            dateOfBirthLabel.TabIndex = 11;
            dateOfBirthLabel.Text = "Date Of Birth:";
            // 
            // placeOfBirthLabel
            // 
            placeOfBirthLabel.AutoSize = true;
            placeOfBirthLabel.Location = new System.Drawing.Point(115, 248);
            placeOfBirthLabel.Name = "placeOfBirthLabel";
            placeOfBirthLabel.Size = new System.Drawing.Size(75, 13);
            placeOfBirthLabel.TabIndex = 13;
            placeOfBirthLabel.Text = "Place Of Birth:";
            // 
            // cityOfAddressLabel
            // 
            cityOfAddressLabel.AutoSize = true;
            cityOfAddressLabel.Location = new System.Drawing.Point(110, 301);
            cityOfAddressLabel.Name = "cityOfAddressLabel";
            cityOfAddressLabel.Size = new System.Drawing.Size(82, 13);
            cityOfAddressLabel.TabIndex = 15;
            cityOfAddressLabel.Text = "City Of Address:";
            // 
            // userNameTextEdit
            // 
            this.userNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.userBindingSource, "UserName", true));
            this.userNameTextEdit.EnterMoveNextControl = true;
            this.userNameTextEdit.Location = new System.Drawing.Point(181, 72);
            this.userNameTextEdit.Name = "userNameTextEdit";
            this.userNameTextEdit.Size = new System.Drawing.Size(100, 20);
            this.userNameTextEdit.TabIndex = 4;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(UserManagementApp.Models.User);
            // 
            // passwordTextEdit
            // 
            this.passwordTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.userBindingSource, "Password", true));
            this.passwordTextEdit.EnterMoveNextControl = true;
            this.passwordTextEdit.Location = new System.Drawing.Point(173, 106);
            this.passwordTextEdit.Name = "passwordTextEdit";
            this.passwordTextEdit.Size = new System.Drawing.Size(100, 20);
            this.passwordTextEdit.TabIndex = 6;
            // 
            // lastNameTextEdit
            // 
            this.lastNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.userBindingSource, "LastName", true));
            this.lastNameTextEdit.EnterMoveNextControl = true;
            this.lastNameTextEdit.Location = new System.Drawing.Point(175, 144);
            this.lastNameTextEdit.Name = "lastNameTextEdit";
            this.lastNameTextEdit.Size = new System.Drawing.Size(100, 20);
            this.lastNameTextEdit.TabIndex = 8;
            // 
            // firstNameTextEdit
            // 
            this.firstNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.userBindingSource, "FirstName", true));
            this.firstNameTextEdit.EnterMoveNextControl = true;
            this.firstNameTextEdit.Location = new System.Drawing.Point(174, 170);
            this.firstNameTextEdit.Name = "firstNameTextEdit";
            this.firstNameTextEdit.Size = new System.Drawing.Size(100, 20);
            this.firstNameTextEdit.TabIndex = 10;
            // 
            // dateOfBirthDateEdit
            // 
            this.dateOfBirthDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.userBindingSource, "DateOfBirth", true));
            this.dateOfBirthDateEdit.EditValue = null;
            this.dateOfBirthDateEdit.EnterMoveNextControl = true;
            this.dateOfBirthDateEdit.Location = new System.Drawing.Point(189, 203);
            this.dateOfBirthDateEdit.Name = "dateOfBirthDateEdit";
            this.dateOfBirthDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateOfBirthDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateOfBirthDateEdit.Properties.MaskSettings.Set("mask", "d");
            this.dateOfBirthDateEdit.Size = new System.Drawing.Size(100, 20);
            this.dateOfBirthDateEdit.TabIndex = 12;
            // 
            // placeOfBirthTextEdit
            // 
            this.placeOfBirthTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.userBindingSource, "PlaceOfBirth", true));
            this.placeOfBirthTextEdit.EnterMoveNextControl = true;
            this.placeOfBirthTextEdit.Location = new System.Drawing.Point(196, 245);
            this.placeOfBirthTextEdit.Name = "placeOfBirthTextEdit";
            this.placeOfBirthTextEdit.Size = new System.Drawing.Size(100, 20);
            this.placeOfBirthTextEdit.TabIndex = 14;
            // 
            // cityOfAddressTextEdit
            // 
            this.cityOfAddressTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.userBindingSource, "CityOfAddress", true));
            this.cityOfAddressTextEdit.EnterMoveNextControl = true;
            this.cityOfAddressTextEdit.Location = new System.Drawing.Point(198, 298);
            this.cityOfAddressTextEdit.Name = "cityOfAddressTextEdit";
            this.cityOfAddressTextEdit.Size = new System.Drawing.Size(100, 20);
            this.cityOfAddressTextEdit.TabIndex = 16;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(117, 357);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(66, 23);
            this.simpleButton1.TabIndex = 17;
            this.simpleButton1.Text = "Save";
            this.simpleButton1.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(232, 357);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(66, 23);
            this.simpleButton2.TabIndex = 18;
            this.simpleButton2.Text = "Cancel";
            this.simpleButton2.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // DetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 450);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(cityOfAddressLabel);
            this.Controls.Add(this.cityOfAddressTextEdit);
            this.Controls.Add(placeOfBirthLabel);
            this.Controls.Add(this.placeOfBirthTextEdit);
            this.Controls.Add(dateOfBirthLabel);
            this.Controls.Add(this.dateOfBirthDateEdit);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.firstNameTextEdit);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.lastNameTextEdit);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.passwordTextEdit);
            this.Controls.Add(userNameLabel);
            this.Controls.Add(this.userNameTextEdit);
            this.Name = "DetailForm";
            this.Text = "DetailForm";
            ((System.ComponentModel.ISupportInitialize)(this.userNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateOfBirthDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateOfBirthDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.placeOfBirthTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityOfAddressTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource userBindingSource;
        private DevExpress.XtraEditors.TextEdit userNameTextEdit;
        private DevExpress.XtraEditors.TextEdit passwordTextEdit;
        private DevExpress.XtraEditors.TextEdit lastNameTextEdit;
        private DevExpress.XtraEditors.TextEdit firstNameTextEdit;
        private DevExpress.XtraEditors.DateEdit dateOfBirthDateEdit;
        private DevExpress.XtraEditors.TextEdit placeOfBirthTextEdit;
        private DevExpress.XtraEditors.TextEdit cityOfAddressTextEdit;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}