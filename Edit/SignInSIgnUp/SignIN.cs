using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ElectoralManagementSystemGUI.DL;
using ElectoralManagementSystemGUI.BL;

namespace ElectoralManagementSystemGUI
{
    public partial class SignIN : Form
    {
        public SignIN()
        {
            InitializeComponent();
        }

        private void ClearDataForm()
        {
            txtUserName.Text = "";
            txtPassword.Text = "";

        }
        private void adminForm()
        {
            adminMenuForm admin = new adminMenuForm();
            voterMenuForm voter = new voterMenuForm();
            if (txtUserName.Text == "admin" && txtPassword.Text == "admin")
            {
                admin.Show();
            }

            else if(txtUserName.Text == "voter" && txtPassword.Text == "voter")
            {
                voter.Show();
            }
            this.Hide();

        }

     
       
        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNext_Click_1(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassword.Text;
            logIN_BL user = new logIN_BL(username, password);
            logIN_BL validUser = logIN_DL.SignIn(user);
            if (validUser != null)
            {
                MessageBox.Show("User is Valid");
            }
            else
            {
                MessageBox.Show("User is Invalid");
            }

             adminForm();
            ClearDataForm();
        }

        private void btnBaack_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
