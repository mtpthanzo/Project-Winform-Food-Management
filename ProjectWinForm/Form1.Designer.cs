namespace ProjectWinForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbManager = new System.Windows.Forms.Label();
            this.dgvFoodList = new System.Windows.Forms.DataGridView();
            this.gbManager = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQuality = new System.Windows.Forms.TextBox();
            this.btnView = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtCateID = new System.Windows.Forms.TextBox();
            this.txtImage = new System.Windows.Forms.TextBox();
            this.txtReleaseDate = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtFoodName = new System.Windows.Forms.TextBox();
            this.txtFoodID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbFoodName = new System.Windows.Forms.Label();
            this.lbFoodID = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbCateName = new System.Windows.Forms.ComboBox();
            this.btnSortByName = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnManagerClient = new System.Windows.Forms.Button();
            this.btnManagerOrder = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnRevenue = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodList)).BeginInit();
            this.gbManager.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbManager
            // 
            this.lbManager.AutoSize = true;
            this.lbManager.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbManager.Location = new System.Drawing.Point(923, 13);
            this.lbManager.Name = "lbManager";
            this.lbManager.Size = new System.Drawing.Size(169, 48);
            this.lbManager.TabIndex = 0;
            this.lbManager.Text = "Manager";
            // 
            // dgvFoodList
            // 
            this.dgvFoodList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFoodList.Location = new System.Drawing.Point(530, 121);
            this.dgvFoodList.Name = "dgvFoodList";
            this.dgvFoodList.RowHeadersWidth = 62;
            this.dgvFoodList.RowTemplate.Height = 33;
            this.dgvFoodList.Size = new System.Drawing.Size(956, 401);
            this.dgvFoodList.TabIndex = 1;
            this.dgvFoodList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFoodList_CellContentClick);
            // 
            // gbManager
            // 
            this.gbManager.Controls.Add(this.label1);
            this.gbManager.Controls.Add(this.txtQuality);
            this.gbManager.Controls.Add(this.btnView);
            this.gbManager.Controls.Add(this.btnDelete);
            this.gbManager.Controls.Add(this.btnUpdate);
            this.gbManager.Controls.Add(this.btnAdd);
            this.gbManager.Controls.Add(this.txtCateID);
            this.gbManager.Controls.Add(this.txtImage);
            this.gbManager.Controls.Add(this.txtReleaseDate);
            this.gbManager.Controls.Add(this.txtQuantity);
            this.gbManager.Controls.Add(this.txtPrice);
            this.gbManager.Controls.Add(this.txtFoodName);
            this.gbManager.Controls.Add(this.txtFoodID);
            this.gbManager.Controls.Add(this.label7);
            this.gbManager.Controls.Add(this.label6);
            this.gbManager.Controls.Add(this.label5);
            this.gbManager.Controls.Add(this.label4);
            this.gbManager.Controls.Add(this.label3);
            this.gbManager.Controls.Add(this.lbFoodName);
            this.gbManager.Controls.Add(this.lbFoodID);
            this.gbManager.Location = new System.Drawing.Point(12, 1);
            this.gbManager.Name = "gbManager";
            this.gbManager.Size = new System.Drawing.Size(502, 580);
            this.gbManager.TabIndex = 2;
            this.gbManager.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Quality";
            // 
            // txtQuality
            // 
            this.txtQuality.Location = new System.Drawing.Point(147, 315);
            this.txtQuality.Name = "txtQuality";
            this.txtQuality.Size = new System.Drawing.Size(329, 31);
            this.txtQuality.TabIndex = 18;
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(16, 488);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(460, 76);
            this.btnView.TabIndex = 17;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(364, 407);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 61);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(181, 407);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(112, 61);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(16, 407);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 61);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add New";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtCateID
            // 
            this.txtCateID.Location = new System.Drawing.Point(148, 352);
            this.txtCateID.Name = "txtCateID";
            this.txtCateID.Size = new System.Drawing.Size(328, 31);
            this.txtCateID.TabIndex = 13;
            // 
            // txtImage
            // 
            this.txtImage.Location = new System.Drawing.Point(148, 276);
            this.txtImage.Name = "txtImage";
            this.txtImage.Size = new System.Drawing.Size(328, 31);
            this.txtImage.TabIndex = 12;
            // 
            // txtReleaseDate
            // 
            this.txtReleaseDate.Location = new System.Drawing.Point(148, 235);
            this.txtReleaseDate.Name = "txtReleaseDate";
            this.txtReleaseDate.Size = new System.Drawing.Size(328, 31);
            this.txtReleaseDate.TabIndex = 11;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(148, 179);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(328, 31);
            this.txtQuantity.TabIndex = 10;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(148, 129);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(328, 31);
            this.txtPrice.TabIndex = 9;
            // 
            // txtFoodName
            // 
            this.txtFoodName.Location = new System.Drawing.Point(148, 74);
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.Size = new System.Drawing.Size(328, 31);
            this.txtFoodName.TabIndex = 8;
            // 
            // txtFoodID
            // 
            this.txtFoodID.Location = new System.Drawing.Point(148, 28);
            this.txtFoodID.Name = "txtFoodID";
            this.txtFoodID.Size = new System.Drawing.Size(328, 31);
            this.txtFoodID.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 352);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Category ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Link Image";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = " Release Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbFoodName
            // 
            this.lbFoodName.AutoSize = true;
            this.lbFoodName.Location = new System.Drawing.Point(16, 77);
            this.lbFoodName.Name = "lbFoodName";
            this.lbFoodName.Size = new System.Drawing.Size(101, 25);
            this.lbFoodName.TabIndex = 1;
            this.lbFoodName.Text = "FoodName";
            // 
            // lbFoodID
            // 
            this.lbFoodID.AutoSize = true;
            this.lbFoodID.Location = new System.Drawing.Point(47, 27);
            this.lbFoodID.Name = "lbFoodID";
            this.lbFoodID.Size = new System.Drawing.Size(70, 25);
            this.lbFoodID.TabIndex = 0;
            this.lbFoodID.Text = "FoodId";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(983, 81);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(349, 31);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1348, 81);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(112, 34);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbCateName
            // 
            this.cbCateName.FormattingEnabled = true;
            this.cbCateName.Items.AddRange(new object[] {
            "Starters",
            "Entrees",
            "Desserts",
            "Beverages",
            "Wines"});
            this.cbCateName.Location = new System.Drawing.Point(530, 78);
            this.cbCateName.Name = "cbCateName";
            this.cbCateName.Size = new System.Drawing.Size(128, 33);
            this.cbCateName.TabIndex = 5;
            this.cbCateName.SelectedIndexChanged += new System.EventHandler(this.cbCateName_SelectedIndexChanged);
            // 
            // btnSortByName
            // 
            this.btnSortByName.Location = new System.Drawing.Point(795, 74);
            this.btnSortByName.Name = "btnSortByName";
            this.btnSortByName.Size = new System.Drawing.Size(150, 38);
            this.btnSortByName.TabIndex = 7;
            this.btnSortByName.Text = "Sort By Name";
            this.btnSortByName.UseVisualStyleBackColor = true;
            this.btnSortByName.Click += new System.EventHandler(this.btnSortByName_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(664, 75);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(112, 36);
            this.btnFilter.TabIndex = 8;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnManagerClient
            // 
            this.btnManagerClient.Location = new System.Drawing.Point(1247, 547);
            this.btnManagerClient.Name = "btnManagerClient";
            this.btnManagerClient.Size = new System.Drawing.Size(223, 34);
            this.btnManagerClient.TabIndex = 9;
            this.btnManagerClient.Text = "Go to manager client";
            this.btnManagerClient.UseVisualStyleBackColor = true;
            this.btnManagerClient.Click += new System.EventHandler(this.btnManagerClient_Click);
            // 
            // btnManagerOrder
            // 
            this.btnManagerOrder.Location = new System.Drawing.Point(1054, 547);
            this.btnManagerOrder.Name = "btnManagerOrder";
            this.btnManagerOrder.Size = new System.Drawing.Size(174, 34);
            this.btnManagerOrder.TabIndex = 10;
            this.btnManagerOrder.Text = "Manager Order";
            this.btnManagerOrder.UseVisualStyleBackColor = true;
            this.btnManagerOrder.Click += new System.EventHandler(this.btnManagerOrder_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(530, 547);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(112, 34);
            this.btnQuit.TabIndex = 11;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnRevenue
            // 
            this.btnRevenue.Location = new System.Drawing.Point(881, 547);
            this.btnRevenue.Name = "btnRevenue";
            this.btnRevenue.Size = new System.Drawing.Size(154, 34);
            this.btnRevenue.TabIndex = 12;
            this.btnRevenue.Text = "Revenue";
            this.btnRevenue.UseVisualStyleBackColor = true;
            this.btnRevenue.Click += new System.EventHandler(this.btnRevenue_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1498, 593);
            this.Controls.Add(this.btnRevenue);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnManagerOrder);
            this.Controls.Add(this.btnManagerClient);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.btnSortByName);
            this.Controls.Add(this.cbCateName);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.gbManager);
            this.Controls.Add(this.dgvFoodList);
            this.Controls.Add(this.lbManager);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodList)).EndInit();
            this.gbManager.ResumeLayout(false);
            this.gbManager.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbManager;
        private DataGridView dgvFoodList;
        private GroupBox gbManager;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label lbFoodName;
        private Label lbFoodID;
        private Label label7;
        private Label label6;
        private TextBox txtCateID;
        private TextBox txtImage;
        private TextBox txtReleaseDate;
        private TextBox txtQuantity;
        private TextBox txtPrice;
        private TextBox txtFoodName;
        private TextBox txtFoodID;
        private TextBox txtSearch;
        private Button btnSearch;
        private ComboBox cbCateName;
        private Button btnView;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private Button btnSortByName;
        private Button btnFilter;
        private Button btnManagerClient;
        private Label label1;
        private TextBox txtQuality;
        private Button btnManagerOrder;
        private Button btnQuit;
        private Button btnRevenue;
    }
}