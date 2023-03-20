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

namespace ProjectWinForm
{
    public partial class frmManagerOrder : Form
    {
        public frmManagerOrder()
        {
            InitializeComponent();
        }
        OrderRepository orderRepository = new OrderRepository();
        BindingSource source = new BindingSource();

        private void frmManagerOrder_Load(object sender, EventArgs e)
        {
            var order = orderRepository.GetOrders();
            source.DataSource = order;
            dgvOrder.DataSource = source;
            cbFilter.SelectedIndex = 0;
        }

        private void dgvOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvOrder.Rows[e.RowIndex];
                OrderObject order = row.DataBoundItem as OrderObject;
                txtCustomerID.Text = order.CustomerID.ToString();
                txtOrderID.Text = order.OrderID.ToString();
                txtOrderDate.Text = order.OrderDate.ToString();
                txtMoney.Text = order.TotalMoney.ToString();
            }
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            var order = orderRepository.GetOrders();
            if(cbFilter.SelectedIndex == 1)
            {
                var orderDate = order.OrderByDescending(item => item.OrderDate).ToList();
                dgvOrder.DataSource = orderDate;
            }
            else if(cbFilter.SelectedIndex == 2)
            {
                var highestPrice = order.OrderByDescending(item => item.TotalMoney).ToList();
                dgvOrder.DataSource = highestPrice;
            }
            else
            {
                var lowestPrice = order.OrderBy(item => item.TotalMoney).ToList();
                dgvOrder.DataSource = lowestPrice;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 form1= new Form1();
            this.Hide();
            form1.ShowDialog(); 
        }

        private void LoadListData()
        {
            var order = orderRepository.GetOrders();
            try
            {
                source = new BindingSource();
                source.DataSource = order;

                txtCustomerID.Clear();
                txtOrderID.Clear();
                txtOrderDate.Clear();
                txtMoney.Clear();
                dgvOrder.DataSource = order;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error");
            }
        }

        private void btnAddNewOrder_Click(object sender, EventArgs e)
        {
            OrderObject orderObject = new OrderObject {
                CustomerID = int.Parse(txtCustomerID.Text),
                OrderDate = txtOrderDate.Text,
                TotalMoney = Decimal.Parse(txtMoney.Text)
            };
            orderRepository.InsertOrder(orderObject);
            LoadListData();
        }

        private void btnUpdateOrder_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtOrderID.Text);
            var getID = orderRepository.GetOrderByID(id);
            if(getID != null)
            {
                getID.CustomerID = int.Parse(txtCustomerID.Text);
                getID.OrderDate = txtOrderDate.Text;
                getID.TotalMoney = Decimal.Parse(txtMoney.Text);
                orderRepository.UpdateOrder(getID); 
                LoadListData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var order = GetOrderObject();
                orderRepository.Delete(order.OrderID);
                LoadListData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete a member");
            }
        }
        private OrderObject GetOrderObject()
        {
            OrderObject order = null;
            try
            {
                order = new OrderObject
                {
                    CustomerID = int.Parse(txtCustomerID.Text),
                    OrderID = int.Parse(txtOrderID.Text),
                    OrderDate = txtOrderDate.Text,
                    TotalMoney= Decimal.Parse(txtMoney.Text),
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Order");
            }
            return order;
        }
        private void btnRefesh_Click(object sender, EventArgs e)
        {
            LoadListData();
        }
    }
}
