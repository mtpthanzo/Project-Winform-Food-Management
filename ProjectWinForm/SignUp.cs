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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        CustomerRepository customerRepository = new CustomerRepository();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login login= new Login();
            this.Hide();
            login.ShowDialog();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            CustomerObject customerObject= new CustomerObject
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Address = txtAddress.Text,
                Gender = rbMale.Checked?"Male" : "Female",
                Telephone= txtTelephone.Text,
                Email= txtEmail.Text,
                UserName= txtUserName.Text,
                Password= txtPassword.Text,
                Role = 2
            };
            if (txtPassword.Text.Equals(txtRepeatssword.Text))
            {
                customerRepository.InsertCustomer(customerObject);
                Login login = new Login();
                this.Hide();
                login.ShowDialog();
            }
            else
            {
                MessageBox.Show("password and repeat password must be equal ");
                txtPassword.Clear();
                txtRepeatssword.Clear();
                txtPassword.Focus();
            }
           
        }
    }
}
