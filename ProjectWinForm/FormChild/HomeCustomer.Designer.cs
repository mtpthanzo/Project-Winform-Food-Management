namespace ProjectWinForm.FormChild
{
    partial class HomeCustomer
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnOrder = new System.Windows.Forms.Button();
            this.nubQuantity = new System.Windows.Forms.NumericUpDown();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lbPriceSearch = new System.Windows.Forms.Label();
            this.cbSort = new System.Windows.Forms.ComboBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.lbFoodID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFoodID = new System.Windows.Forms.TextBox();
            this.txtReleaseDate = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nubQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 157);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1119, 437);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(824, 119);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(307, 31);
            this.btnOrder.TabIndex = 2;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // nubQuantity
            // 
            this.nubQuantity.Location = new System.Drawing.Point(476, 120);
            this.nubQuantity.Name = "nubQuantity";
            this.nubQuantity.Size = new System.Drawing.Size(342, 31);
            this.nubQuantity.TabIndex = 5;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(12, 14);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(294, 31);
            this.txtSearch.TabIndex = 7;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(325, 11);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(115, 36);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(456, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(466, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Price";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(521, 17);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(235, 31);
            this.txtName.TabIndex = 13;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(521, 72);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(235, 31);
            this.txtPrice.TabIndex = 14;
            // 
            // lbPriceSearch
            // 
            this.lbPriceSearch.AutoSize = true;
            this.lbPriceSearch.Location = new System.Drawing.Point(187, 72);
            this.lbPriceSearch.Name = "lbPriceSearch";
            this.lbPriceSearch.Size = new System.Drawing.Size(0, 25);
            this.lbPriceSearch.TabIndex = 16;
            // 
            // cbSort
            // 
            this.cbSort.FormattingEnabled = true;
            this.cbSort.Items.AddRange(new object[] {
            "Price ascending",
            "Price descending",
            "Name  A -> Z",
            "Name Z -> A"});
            this.cbSort.Location = new System.Drawing.Point(12, 90);
            this.cbSort.Name = "cbSort";
            this.cbSort.Size = new System.Drawing.Size(294, 33);
            this.cbSort.TabIndex = 17;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(325, 90);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(112, 34);
            this.btnFilter.TabIndex = 18;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // lbFoodID
            // 
            this.lbFoodID.AutoSize = true;
            this.lbFoodID.Location = new System.Drawing.Point(794, 20);
            this.lbFoodID.Name = "lbFoodID";
            this.lbFoodID.Size = new System.Drawing.Size(72, 25);
            this.lbFoodID.TabIndex = 19;
            this.lbFoodID.Text = "FoodID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(768, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "ReleaseDate";
            // 
            // txtFoodID
            // 
            this.txtFoodID.Location = new System.Drawing.Point(888, 20);
            this.txtFoodID.Name = "txtFoodID";
            this.txtFoodID.Size = new System.Drawing.Size(243, 31);
            this.txtFoodID.TabIndex = 21;
            // 
            // txtReleaseDate
            // 
            this.txtReleaseDate.Location = new System.Drawing.Point(888, 78);
            this.txtReleaseDate.Name = "txtReleaseDate";
            this.txtReleaseDate.Size = new System.Drawing.Size(243, 31);
            this.txtReleaseDate.TabIndex = 22;
            // 
            // HomeCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 606);
            this.Controls.Add(this.txtReleaseDate);
            this.Controls.Add(this.txtFoodID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbFoodID);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.cbSort);
            this.Controls.Add(this.lbPriceSearch);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.nubQuantity);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.dataGridView1);
            this.Name = "HomeCustomer";
            this.Text = "HomeCustomer";
            this.Load += new System.EventHandler(this.HomeCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nubQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnOrder;
        private NumericUpDown nubQuantity;
        private TextBox txtSearch;
        private Button btnSearch;
        private Label label3;
        private Label label4;
        private TextBox txtName;
        private TextBox txtPrice;
        private Label lbPriceSearch;
        private ComboBox cbSort;
        private Button btnFilter;
        private Label lbFoodID;
        private Label label2;
        private TextBox txtFoodID;
        private TextBox txtReleaseDate;
    }
}