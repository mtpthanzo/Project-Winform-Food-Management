using ProjectLibrary.Model;
using ProjectLibrary.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectWinForm
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        ICustomerRepository customerRepository1 = new CustomerRepository();
        private bool checkInfor(string username, string password)
        {
            CustomerRepository customerRepository = new CustomerRepository();
            var check = customerRepository.GetCustomers();
            foreach (var nick in check)
            {
                if (nick.UserName.Equals(username) && nick.Password.Equals(password))
                {
                    return true;
                }
            }
            return false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string password = txtPassword.Text;
            CustomerRepository customerRepository = new CustomerRepository();
            var check = customerRepository.GetCustomers();
            var temp = (from nick in check where nick.UserName == userName && nick.Password == password select nick).FirstOrDefault();
            if (temp != null)
            {
                    
                    if (temp.Role == 1)
                    {
                        Form1 form1 = new Form1();
                        this.Hide();
                        form1.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        this.Hide();
                        FormCustomer formCustomer = new FormCustomer() { customerInfor = temp};
                        formCustomer.ShowDialog();
                        this.Close();
                    }
                    return;  
            }
            foreach(var nick in check)
            {
                if (!nick.UserName.Contains(txtUserName.Text) || !nick.Password.Contains(txtPassword.Text)) { }
                {
                    txtUserName.Clear();
                    txtPassword.Clear();
                    MessageBox.Show("UserName or Password is not correct!");
                    txtUserName.Focus();
                }
                return;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.ShowDialog();
        }
    }
}
