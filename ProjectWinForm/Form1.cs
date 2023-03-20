using ProjectLibrary.Model;
using ProjectLibrary.Repository;

namespace ProjectWinForm
{
    public partial class Form1 : Form
    {
        MenuRepository menuRepository = new MenuRepository();
        BindingSource source = new BindingSource();
        public Form1()
        {
            InitializeComponent();
        }
       

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var menu = menuRepository.GetMenus();
            source.DataSource = menu;
            dgvFoodList.DataSource = source;
            cbCateName.SelectedIndex = 0;
        }

        private void LoadData(object m)
        {
            try
            {
                source = new BindingSource();
                source.DataSource = m;
                dgvFoodList.DataSource = source;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load member list");
            }
        }

        private void LoadDataList()
        {
            var menu = menuRepository.GetMenus();
            try
            {
                source = new BindingSource();
                source.DataSource = menu;

                txtFoodID.DataBindings.Clear();
                txtFoodName.DataBindings.Clear();
                txtQuantity.DataBindings.Clear();
                txtPrice.DataBindings.Clear();
                txtReleaseDate.DataBindings.Clear();
                txtQuality.DataBindings.Clear();
                txtImage.DataBindings.Clear();
                txtCateID.DataBindings.Clear();

                txtCateID.DataBindings.Add("Text", source, "CateID");
                txtFoodID.DataBindings.Add("Text", source, "FoodID");
                txtQuantity.DataBindings.Add("Text", source, "Quantity");
                txtPrice.DataBindings.Add("Text", source, "Price");
                txtReleaseDate.DataBindings.Add("Text", source, "ReleaseDate");
                txtImage.DataBindings.Add("Text", source, "Image");
                txtQuality.DataBindings.Add("Text", source, "Quanlity");
                txtFoodName.DataBindings.Add("Text", source, "FoodName");

                dgvFoodList.DataSource = null;
                dgvFoodList.DataSource = source;

                if (menu.Count() == 0)
                {
                    ClearText();
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load member list");
            }
        }
        private void ClearText()
        {
            txtFoodID.Text = string.Empty;
            txtFoodName.Text = string.Empty;
            txtImage.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtQuantity.Text = string.Empty;
            txtReleaseDate.Text = string.Empty;
            txtCateID.Text = string.Empty;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string foodName = txtSearch.Text;
            var me = menuRepository.GetMenus();
            var menuFoodName = from m in me where m.FoodName.ToLower().Contains(foodName) select m;
            if (menuFoodName.Count() > 0)
            {
                LoadData(menuFoodName);
            }
            else
            {
                MessageBox.Show("Not found food");
            }
        }

        private void btnSortByName_Click(object sender, EventArgs e)
        {
            var me = menuRepository.GetMenus();
            var menuFoodName = from m in me orderby m.FoodName select m;
            if (menuFoodName.Count() > 0)
            {
                LoadData(menuFoodName);
            }
            else
            {
                MessageBox.Show("Not found food");
            }
        }

        private void cbCateName_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void filterByCateID()
        {
            var emp = menuRepository.GetMenus();
            if (cbCateName.SelectedIndex == 0)
            {
                var empMenuCateNameFirst = from m in emp where (m.CateID == 1) select m;
                if(empMenuCateNameFirst.Count() > 0)
                {
                    LoadData(empMenuCateNameFirst);
                }
            }
            else if (cbCateName.SelectedIndex == 1)
            {
                var empMenuCateNameFirst = from m in emp where (m.CateID == 2) select m;
                if (empMenuCateNameFirst.Count() > 0)
                {
                    LoadData(empMenuCateNameFirst);
                }
            }
            else if (cbCateName.SelectedIndex == 2)
            {
                var empMenuCateNameFirst = from m in emp where (m.CateID == 3) select m;
                if (empMenuCateNameFirst.Count() > 0)
                {
                    LoadData(empMenuCateNameFirst);
                }
            }
            else if (cbCateName.SelectedIndex == 3)
            {
                var empMenuCateNameFirst = from m in emp where (m.CateID == 4) select m;
                if (empMenuCateNameFirst.Count() > 0)
                {
                    LoadData(empMenuCateNameFirst);
                }
            }
            else
            {
                var empMenuCateNameFirst = from m in emp where (m.CateID == 5) select m;
                if (empMenuCateNameFirst.Count() > 0)
                {
                    LoadData(empMenuCateNameFirst);
                }
            }

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            MenuObject menuObject = new MenuObject
            {
                //FoodId= int.Parse(txtFoodID.Text),
                FoodName = txtFoodName.Text,
                Price = double.Parse(txtPrice.Text),
                Quantity = int.Parse(txtQuantity.Text),
                ReleaseDate = txtReleaseDate.Text,
                Quanlity = txtQuality.Text,
                Image = txtImage.Text,
                CateID = int.Parse(txtCateID.Text)
            };
            menuRepository.InsertMenu(menuObject);
            LoadDataList();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int foodId = int.Parse(txtFoodID.Text);
            var menuDetail = menuRepository.GetMenuByID(foodId);
            if(menuDetail != null)
            {
                menuDetail.FoodName = txtFoodName.Text;
                menuDetail.Price = double.Parse(txtPrice.Text);
                menuDetail.ReleaseDate = txtReleaseDate.Text;
                menuDetail.Quantity= int.Parse(txtQuantity.Text);
                menuDetail.Image = txtImage.Text;
                menuDetail.Quanlity = txtQuality.Text;
                menuDetail.CateID = int.Parse(txtCateID.Text);
                menuRepository.UpdateMenu(menuDetail);
                LoadDataList();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var menu = GetMenuObject();
                menuRepository.Delete(menu.FoodId);
                LoadDataList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete a member");
            }
        }
        private MenuObject GetMenuObject()
        {
            MenuObject menu = null;
            try
            {
                menu = new MenuObject
                {
                    FoodId = int.Parse(txtFoodID.Text),
                    FoodName = txtFoodName.Text,
                    Price = double.Parse(txtPrice.Text),
                    Quantity = int.Parse(txtQuantity.Text),
                    Image = txtImage.Text,
                    ReleaseDate = txtReleaseDate.Text,
                    CateID = int.Parse(txtCateID.Text)
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Member");
            }
            return menu;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            LoadDataList();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            filterByCateID();
        }

        private void dgvFoodList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnManagerClient_Click(object sender, EventArgs e)
        {
            frmManagerClient frmManager = new frmManagerClient();
            this.Hide();
            frmManager.ShowDialog();
        }

        private void btnManagerOrder_Click(object sender, EventArgs e)
        {
            frmManagerOrder frmManagerOrder = new frmManagerOrder();
            this.Hide();
            frmManagerOrder.ShowDialog();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
        }

        private void btnRevenue_Click(object sender, EventArgs e)
        {
            RevenueChart revenueChart = new RevenueChart();
            this.Hide();
            revenueChart.ShowDialog();
        }
    }
}