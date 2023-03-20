using Microsoft.VisualBasic;
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
    public partial class frmManagerClient : Form
    {
        public frmManagerClient()
        {
            InitializeComponent();
        }

        CustomerRepository customerRepository = new CustomerRepository();
        BindingSource source = new BindingSource();
        private void frmManagerClient_Load(object sender, EventArgs e)
        {
           var cus= customerRepository.GetCustomers();
            source.DataSource = cus;
            dgvListCustomer.DataSource = cus;
        }
        private void LoadData(object m)
        {
            try
            {
                source = new BindingSource();
                source.DataSource = m;
                dgvListCustomer.DataSource = source;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load member list");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CustomerObject customerObject = new CustomerObject
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Address = txtAddress.Text,
                Gender = rbMale.Checked ? "Male" : "Female",
                Telephone = txtTelephone.Text,
                Email = txtEmail.Text,
                UserName = txtUserName.Text,
                Password = txtPassword.Text,
                Role = 2,
            };
            customerRepository.InsertCustomer(customerObject);
            LoadListData();
        }

        private void LoadListData()
        {
            var cus = customerRepository.GetCustomers();
            try
            {
                source = new BindingSource();
                source.DataSource = cus;
                dgvListCustomer.DataSource = cus;
            }catch(Exception ex)
            {
                MessageBox.Show("Error");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string firstName = txtSearch.Text;
            string lastName = txtSearch.Text;
            var cus = customerRepository.GetCustomers();
            var customerFirstName = from m in cus where m.FirstName.ToLower().Contains(firstName.ToLower()) select m;
            var customerLastName = from m in cus where m.LastName.ToLower().Contains(lastName.ToLower()) select m;
            if (customerFirstName.Count()>0)
            {
                LoadData(customerFirstName);
            }
            else if (customerLastName.Count() > 0)
            {
                LoadData(customerLastName);
            }
            else
            {
                MessageBox.Show("Not found the customer");
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvListCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
               DataGridViewRow row = dgvListCustomer.Rows[e.RowIndex];
               CustomerObject customer = row.DataBoundItem as CustomerObject;
                txtFirstName.Text = customer.FirstName.ToString();
                txtLastName.Text = customer.LastName.ToString();    
                txtTelephone.Text = customer.Telephone.ToString();
                if (customer.Gender.Equals("Male"))
                {
                    rbMale.Checked = true;
                }
                else
                {
                    rbFemale.Checked = true;
                }
                txtEmail.Text = customer.Email.ToString();
                txtAddress.Text = customer.Address.ToString();
                txtUserName.Text = customer.UserName.ToString();
                txtPassword.Text= customer.Password.ToString();  
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 form1= new Form1();   
            this.Hide();
            form1.ShowDialog();
        }

    }
}
