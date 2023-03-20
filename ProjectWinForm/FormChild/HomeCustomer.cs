using ProjectLibrary.Model;
using ProjectLibrary.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;
using System.Linq;
namespace ProjectWinForm.FormChild
{
    public partial class HomeCustomer : Form
    {
        public HomeCustomer()
        {
            InitializeComponent();
        }
        IMenuReporitory menuReporitory = new MenuRepository();

        IOrderRepository orderRepository = new OrderRepository();

        BindingSource source = new BindingSource();
        public CustomerObject customerInfor { get; set; }

        private void HomeCustomer_Load(object sender, EventArgs e)
        {
            var menu = menuReporitory.GetMenus();
            source.DataSource = menu;
            dataGridView1.DataSource = menu;
            cbSort.SelectedIndex = 0; 
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[7].Visible = false;
        }
        private void LoadData(object m)
        {
            try
            {
                source = new BindingSource();
                source.DataSource = m;
                dataGridView1.DataSource = source;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load member list");
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string foodName = txtSearch.Text;
            var menu = menuReporitory.GetMenus();
            var menuFoodName = from m in menu where m.FoodName.Contains(foodName) select m;
            if(menuFoodName.Count() > 0)
            {
                LoadData(menuFoodName);
            }
            else
            {
                MessageBox.Show("Not Found");
            }
        }
        private void btnBuy_Click(object sender, EventArgs e)
        {
            OrderObject orderObject = new OrderObject {
                CustomerID = customerInfor.CustomerID,
                OrderDate = DateTime.Now.ToString(),
                TotalMoney = (Decimal)((int)nubQuantity.Value * double.Parse(txtPrice.Text)),
                FoodID = int.Parse(txtFoodID.Text),
                Quantity = (int)nubQuantity.Value
            };
            orderRepository.InsertOrder(orderObject);
            HomeCustomer_Load(sender, e);
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtName.DataBindings.Clear();
                txtPrice.DataBindings.Clear();
                txtReleaseDate.DataBindings.Clear();
                txtFoodID.DataBindings.Clear();

                txtName.DataBindings.Add("Text",source, "FoodName");
                txtPrice.DataBindings.Add("Text", source, "Price");
                txtReleaseDate.DataBindings.Add("Text", source, "ReleaseDate");
                txtFoodID.DataBindings.Add("Text", source, "FoodID");



                dataGridView1.DataSource = null;
                dataGridView1.DataSource = source;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load member list");
            }
        }
        private void btnFilter_Click(object sender, EventArgs e)
        {
            var menu = menuReporitory.GetMenus();
            if (cbSort.SelectedIndex == 0)
            {
                var sortedItems = menu.OrderBy(item => item.Price).ToList();
                dataGridView1.DataSource = sortedItems;
            }
            else if (cbSort.SelectedIndex == 1)
            {
                var sortedItems1 = menu.OrderByDescending(item => item.Price).ToList();
                dataGridView1.DataSource = sortedItems1;
            }
            else if (cbSort.SelectedIndex == 2)
            {
                var sortedItems1 = menu.OrderBy(item => item.FoodName).ToList();
                dataGridView1.DataSource = sortedItems1;
            }
            else
            {
                var sortedItems1 = menu.OrderByDescending(item => item.FoodName).ToList();
                dataGridView1.DataSource = sortedItems1;
            }
        }

    }
}
