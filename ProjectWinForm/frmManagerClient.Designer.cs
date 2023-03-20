namespace ProjectWinForm
{
    partial class frmManagerClient
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvListCustomer = new System.Windows.Forms.DataGridView();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.lbLastName = new System.Windows.Forms.Label();
            this.lbTelephone = new System.Windows.Forms.Label();
            this.lbGender = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbAddress = new System.Windows.Forms.Label();
            this.lbUserName = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(490, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manager Client";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvListCustomer
            // 
            this.dgvListCustomer.AllowUserToAddRows = false;
            this.dgvListCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListCustomer.Location = new System.Drawing.Point(12, 228);
            this.dgvListCustomer.Name = "dgvListCustomer";
            this.dgvListCustomer.RowHeadersWidth = 62;
            this.dgvListCustomer.RowTemplate.Height = 33;
            this.dgvListCustomer.Size = new System.Drawing.Size(1300, 359);
            this.dgvListCustomer.TabIndex = 1;
            this.dgvListCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListCustomer_CellContentClick);
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.Location = new System.Drawing.Point(12, 84);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(92, 25);
            this.lbFirstName.TabIndex = 2;
            this.lbFirstName.Text = "FirstName";
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.Location = new System.Drawing.Point(14, 136);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(90, 25);
            this.lbLastName.TabIndex = 3;
            this.lbLastName.Text = "LastName";
            // 
            // lbTelephone
            // 
            this.lbTelephone.AutoSize = true;
            this.lbTelephone.Location = new System.Drawing.Point(12, 182);
            this.lbTelephone.Name = "lbTelephone";
            this.lbTelephone.Size = new System.Drawing.Size(92, 25);
            this.lbTelephone.TabIndex = 4;
            this.lbTelephone.Text = "Telephone";
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Location = new System.Drawing.Point(342, 84);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(69, 25);
            this.lbGender.TabIndex = 5;
            this.lbGender.Text = "Gender";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(342, 133);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(54, 25);
            this.lbEmail.TabIndex = 6;
            this.lbEmail.Text = "Email";
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Location = new System.Drawing.Point(338, 186);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(77, 25);
            this.lbAddress.TabIndex = 7;
            this.lbAddress.Text = "Address";
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Location = new System.Drawing.Point(779, 91);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(94, 25);
            this.lbUserName.TabIndex = 8;
            this.lbUserName.Text = "UserName";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(786, 143);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(87, 25);
            this.lbPassword.TabIndex = 9;
            this.lbPassword.Text = "Password";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(1200, 83);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 85);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnBack
            // 
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(83, 34);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "Back ";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(110, 82);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(206, 31);
            this.txtFirstName.TabIndex = 14;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(110, 130);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(206, 31);
            this.txtLastName.TabIndex = 15;
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(110, 180);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(206, 31);
            this.txtTelephone.TabIndex = 16;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(441, 83);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(75, 29);
            this.rbMale.TabIndex = 17;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(585, 83);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(93, 29);
            this.rbFemale.TabIndex = 18;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(421, 186);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(325, 31);
            this.txtAddress.TabIndex = 20;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(919, 85);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(261, 31);
            this.txtUserName.TabIndex = 21;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(919, 137);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(261, 31);
            this.txtPassword.TabIndex = 22;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(786, 183);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(394, 31);
            this.txtSearch.TabIndex = 23;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1200, 183);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(112, 34);
            this.btnSearch.TabIndex = 24;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(424, 131);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(322, 31);
            this.txtEmail.TabIndex = 26;
            // 
            // frmManagerClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 599);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.txtTelephone);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbUserName);
            this.Controls.Add(this.lbAddress);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbGender);
            this.Controls.Add(this.lbTelephone);
            this.Controls.Add(this.lbLastName);
            this.Controls.Add(this.lbFirstName);
            this.Controls.Add(this.dgvListCustomer);
            this.Controls.Add(this.label1);
            this.Name = "frmManagerClient";
            this.Text = "frmManagerClient";
            this.Load += new System.EventHandler(this.frmManagerClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DataGridView dgvListCustomer;
        private Label lbFirstName;
        private Label lbLastName;
        private Label lbTelephone;
        private Label lbGender;
        private Label lbEmail;
        private Label lbAddress;
        private Label lbUserName;
        private Label lbPassword;
        private Button btnAdd;
        private Button btnBack;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtTelephone;
        private RadioButton rbMale;
        private RadioButton rbFemale;
        private TextBox txtAddress;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private TextBox txtSearch;
        private Button btnSearch;
        private TextBox txtEmail;
    }
}