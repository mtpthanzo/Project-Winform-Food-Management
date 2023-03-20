namespace ProjectWinForm
{
    partial class FormCustomer
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnHomeProduct = new System.Windows.Forms.Button();
            this.pLogo = new System.Windows.Forms.Panel();
            this.lbCustomer = new System.Windows.Forms.Label();
            this.pDesktop = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.pLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnProfile);
            this.panel1.Controls.Add(this.btnHomeProduct);
            this.panel1.Controls.Add(this.pLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 605);
            this.panel1.TabIndex = 0;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogOut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogOut.Location = new System.Drawing.Point(0, 292);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(259, 101);
            this.btnLogOut.TabIndex = 5;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProfile.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProfile.Location = new System.Drawing.Point(0, 199);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(259, 93);
            this.btnProfile.TabIndex = 3;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnHomeProduct
            // 
            this.btnHomeProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHomeProduct.FlatAppearance.BorderSize = 0;
            this.btnHomeProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHomeProduct.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHomeProduct.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHomeProduct.Location = new System.Drawing.Point(0, 101);
            this.btnHomeProduct.Name = "btnHomeProduct";
            this.btnHomeProduct.Size = new System.Drawing.Size(259, 98);
            this.btnHomeProduct.TabIndex = 1;
            this.btnHomeProduct.Text = "Home";
            this.btnHomeProduct.UseVisualStyleBackColor = true;
            this.btnHomeProduct.Click += new System.EventHandler(this.btnHomeProduct_Click);
            // 
            // pLogo
            // 
            this.pLogo.BackColor = System.Drawing.Color.DimGray;
            this.pLogo.Controls.Add(this.lbCustomer);
            this.pLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pLogo.Location = new System.Drawing.Point(0, 0);
            this.pLogo.Name = "pLogo";
            this.pLogo.Size = new System.Drawing.Size(259, 101);
            this.pLogo.TabIndex = 0;
            // 
            // lbCustomer
            // 
            this.lbCustomer.AutoSize = true;
            this.lbCustomer.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbCustomer.Location = new System.Drawing.Point(23, 23);
            this.lbCustomer.Name = "lbCustomer";
            this.lbCustomer.Size = new System.Drawing.Size(224, 60);
            this.lbCustomer.TabIndex = 0;
            this.lbCustomer.Text = "Customer";
            // 
            // pDesktop
            // 
            this.pDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pDesktop.Location = new System.Drawing.Point(259, 0);
            this.pDesktop.Name = "pDesktop";
            this.pDesktop.Size = new System.Drawing.Size(1162, 605);
            this.pDesktop.TabIndex = 1;
            // 
            // FormCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1421, 605);
            this.Controls.Add(this.pDesktop);
            this.Controls.Add(this.panel1);
            this.Name = "FormCustomer";
            this.Text = "FormCustomer";
            this.panel1.ResumeLayout(false);
            this.pLogo.ResumeLayout(false);
            this.pLogo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel pLogo;
        private Button btnHomeProduct;
        private Button btnLogOut;
        private Button btnProfile;
        private Label lbCustomer;
        private Panel pDesktop;
    }
}