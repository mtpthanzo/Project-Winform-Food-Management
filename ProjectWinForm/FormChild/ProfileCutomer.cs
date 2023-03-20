using ProjectLibrary.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectWinForm.FormChild
{
    public partial class ProfileCutomer : Form
    {
        public ProfileCutomer()
        {
            InitializeComponent();
        }
        public CustomerObject customerInfor { get; set; }

        private void ProfileCutomer_Load(object sender, EventArgs e)
        {
            txtFirstName.Text = customerInfor.FirstName;
            txtLastName.Text = customerInfor.LastName;
            if (customerInfor.Gender =="Male")
            {
                rbMale.Checked = true;
            }
            else
            {
                rbFemale.Checked = true;
            }
            txtAddress.Text = customerInfor.Address;
            txtTelephone.Text = customerInfor.Telephone;
            txtEmail.Text = customerInfor.Email;
            txtUserName.Text = customerInfor.UserName;
            txtPassword.Text = customerInfor.Password;
        }

    }
}
