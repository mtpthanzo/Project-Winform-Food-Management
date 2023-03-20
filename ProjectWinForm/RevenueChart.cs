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
    public partial class RevenueChart : Form
    {
        public RevenueChart()
        {
            InitializeComponent();
        }

        IOrderRepository orderRepository = new OrderRepository();
        BindingSource source = new BindingSource();


        private void RevenueChart_Load(object sender, EventArgs e)
        {
            chart1.DataSource = orderRepository.GetOrderRevenue();
            chart1.Series["Revenue"].YValueMembers = "TotalMoney";
            chart1.Series["Revenue"].XValueMember = "OrderID";

            chart2.DataSource = orderRepository.GetOrderQuantityProduct();
            chart2.Series["Product"].YValueMembers = "FoodID";
            chart2.Series["Product"].XValueMember = "OrderID";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.ShowDialog();
        }
    }
}
