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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }


        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void lblSigINSignUP_Click(object sender, EventArgs e)
        {

        }

        private void ClearDataForm()
        {
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtRole.Text = "";
        }

      

     
        private void btnNext_Click_1(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassword.Text;
            string role = txtRole.Text;
            string path = "logIn.txt";
            logIN_BL user = new logIN_BL(username, password, role);
            logIN_DL.addUserIntoList(user);
            logIN_DL.storeLoginData(user, path);
            MessageBox.Show("User Added Successfully");

            ClearDataForm();

        }

        private void btnBaack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
