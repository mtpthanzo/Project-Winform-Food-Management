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

namespace ProjectWinForm
{
    public partial class FormCustomer : Form
    {
        private Button currentButton;
        //private int tmpIndex;
        private Form activeForm;
        public CustomerObject customerInfor { get; set; }

        public FormCustomer()
        {
            InitializeComponent();
        }

        private void ActiveButton(object btnSender)
        {
            if(btnSender != null)
            {
                if(currentButton!= (Button)btnSender) {
                currentButton = (Button) btnSender;
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if(activeForm!= null)
            {
                activeForm.Close();
            }
            ActiveButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle= FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pDesktop.Controls.Add(childForm);
            this.pDesktop.Tag = childForm;
            childForm.BringToFront(); 
            childForm.Show();
        }


        private void btnHomeProduct_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormChild.HomeCustomer() { customerInfor = customerInfor }, sender);
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormChild.ProfileCutomer() { customerInfor = customerInfor } , sender);
        }
            
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
        }
    }
}
