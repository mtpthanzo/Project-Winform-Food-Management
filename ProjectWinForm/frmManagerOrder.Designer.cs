namespace ProjectWinForm
{
    partial class frmManagerOrder
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lbOrderID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.txtOrderDate = new System.Windows.Forms.TextBox();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.btnAddNewOrder = new System.Windows.Forms.Button();
            this.btnUpdateOrder = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRefesh = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvOrder);
            this.groupBox1.Location = new System.Drawing.Point(4, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(503, 331);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order";
            // 
            // dgvOrder
            // 
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Location = new System.Drawing.Point(4, 18);
            this.dgvOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.RowHeadersWidth = 62;
            this.dgvOrder.RowTemplate.Height = 33;
            this.dgvOrder.Size = new System.Drawing.Size(494, 310);
            this.dgvOrder.TabIndex = 0;
            this.dgvOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrder_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(507, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "CustomerID";
            // 
            // lbOrderID
            // 
            this.lbOrderID.AutoSize = true;
            this.lbOrderID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbOrderID.Location = new System.Drawing.Point(538, 69);
            this.lbOrderID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbOrderID.Name = "lbOrderID";
            this.lbOrderID.Size = new System.Drawing.Size(70, 21);
            this.lbOrderID.TabIndex = 2;
            this.lbOrderID.Text = "OrderID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(514, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Order Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(547, 165);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Money";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCustomerID.Location = new System.Drawing.Point(629, 24);
            this.txtCustomerID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCustomerID.Multiline = true;
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(186, 29);
            this.txtCustomerID.TabIndex = 5;
            // 
            // txtOrderID
            // 
            this.txtOrderID.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtOrderID.Location = new System.Drawing.Point(626, 69);
            this.txtOrderID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtOrderID.Multiline = true;
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(189, 32);
            this.txtOrderID.TabIndex = 6;
            // 
            // txtOrderDate
            // 
            this.txtOrderDate.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtOrderDate.Location = new System.Drawing.Point(626, 118);
            this.txtOrderDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtOrderDate.Multiline = true;
            this.txtOrderDate.Name = "txtOrderDate";
            this.txtOrderDate.Size = new System.Drawing.Size(189, 30);
            this.txtOrderDate.TabIndex = 7;
            // 
            // txtMoney
            // 
            this.txtMoney.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMoney.Location = new System.Drawing.Point(626, 165);
            this.txtMoney.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMoney.Multiline = true;
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(189, 32);
            this.txtMoney.TabIndex = 8;
            // 
            // btnAddNewOrder
            // 
            this.btnAddNewOrder.Location = new System.Drawing.Point(511, 269);
            this.btnAddNewOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddNewOrder.Name = "btnAddNewOrder";
            this.btnAddNewOrder.Size = new System.Drawing.Size(78, 34);
            this.btnAddNewOrder.TabIndex = 9;
            this.btnAddNewOrder.Text = "Add";
            this.btnAddNewOrder.UseVisualStyleBackColor = true;
            this.btnAddNewOrder.Click += new System.EventHandler(this.btnAddNewOrder_Click);
            // 
            // btnUpdateOrder
            // 
            this.btnUpdateOrder.Location = new System.Drawing.Point(629, 269);
            this.btnUpdateOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdateOrder.Name = "btnUpdateOrder";
            this.btnUpdateOrder.Size = new System.Drawing.Size(78, 34);
            this.btnUpdateOrder.TabIndex = 10;
            this.btnUpdateOrder.Text = "Update";
            this.btnUpdateOrder.UseVisualStyleBackColor = true;
            this.btnUpdateOrder.Click += new System.EventHandler(this.btnUpdateOrder_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(743, 269);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(78, 34);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRefesh
            // 
            this.btnRefesh.Location = new System.Drawing.Point(675, 310);
            this.btnRefesh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRefesh.Name = "btnRefesh";
            this.btnRefesh.Size = new System.Drawing.Size(146, 27);
            this.btnRefesh.TabIndex = 12;
            this.btnRefesh.Text = "Refesh";
            this.btnRefesh.UseVisualStyleBackColor = true;
            this.btnRefesh.Click += new System.EventHandler(this.btnRefesh_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(514, 310);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(139, 27);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cbFilter
            // 
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "Filter",
            "Order date latest",
            "Highest price",
            "Lowest price"});
            this.cbFilter.Location = new System.Drawing.Point(514, 214);
            this.cbFilter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(301, 23);
            this.cbFilter.TabIndex = 14;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // frmManagerOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 344);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnRefesh);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdateOrder);
            this.Controls.Add(this.btnAddNewOrder);
            this.Controls.Add(this.txtMoney);
            this.Controls.Add(this.txtOrderDate);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbOrderID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmManagerOrder";
            this.Text = "frmManagerOrder";
            this.Load += new System.EventHandler(this.frmManagerOrder_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dgvOrder;
        private Label label1;
        private Label lbOrderID;
        private Label label3;
        private Label label4;
        private TextBox txtCustomerID;
        private TextBox txtOrderID;
        private TextBox txtOrderDate;
        private TextBox txtMoney;
        private Button btnAddNewOrder;
        private Button btnUpdateOrder;
        private Button btnDelete;
        private Button btnRefesh;
        private Button btnBack;
        private ComboBox cbFilter;
    }
}