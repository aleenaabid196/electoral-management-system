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
    public partial class FormSignInSignUp : Form
    {
        public FormSignInSignUp()
        {
            InitializeComponent();
            string path = "logIn.txt";
            if (logIN_DL.loadLoginData(path))
            {
                MessageBox.Show("Data Loaded From the File Successfully");
            }
            else
            {
                MessageBox.Show("Data not Loaded.");
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (cBSignIN.Checked)
            {
                
                Form f = new SignIN();
                f.Show(); 
                cBSignIN.Checked = false;
                
            }

            else if (cBSignUP.Checked)
            {
                
                Form f = new SignUp();
                f.Show();
                cBSignUP.Checked = false;
                
            }
           
        }

        private void cBSignUP_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblSigINSignUP_Click(object sender, EventArgs e)
        {

        }
    }
}
