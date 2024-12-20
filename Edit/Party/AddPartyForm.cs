using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElectoralManagementSystemGUI.BL;
using ElectoralManagementSystemGUI.DL;
using System.Windows.Forms;

namespace ElectoralManagementSystemGUI
{
    public partial class AddPartyForm : Form
    {
        int AGE,id, year;
        public AddPartyForm()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                 AGE = int.Parse(txtAddPartyAge.Text);
                id = int.Parse(txtAddPartyID.Text);
                year = int.Parse(txtAddPartyYear.Text);
                if (AGE <=0 || id <= 0 || year <= 0)
                {
                    throw new Exception("Input Valid. Please enter Again.");
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
                return;
            }
            
            Party_BL party = new Party_BL(txtAddPartyName.Text, id, AGE, txtAddParty.Text, txtAddPartyEmail.Text, year);
            Party_DL.addPartyIntoList(party);
            this.Close();
        }

    }
}
