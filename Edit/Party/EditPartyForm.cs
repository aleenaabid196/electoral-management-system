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
    public partial class EditPartyForm : Form
    {
        int AGE, id, year;
        private Party_BL previous;
        public EditPartyForm(Party_BL previous)
        {
            InitializeComponent();
            this.previous = previous;
        }

        private void EditPartyForm_Load(object sender, EventArgs e)
        {
            txtEditPartyName.Text = previous.Name1;
            txtEditPartyID.Text = previous.ID1.ToString();
            txtEditPartyAge.Text = previous.Age.ToString();
            txtEditParty.Text = previous.PartyNamesA;
            txtEditPartyEmail.Text = previous.PartyEmailA;
            txtEditPartyYear.Text = previous.PartyYearA.ToString();
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                AGE = int.Parse(txtEditPartyAge.Text);
                id = int.Parse(txtEditPartyID.Text);
                year = int.Parse(txtEditPartyYear.Text);
                if (AGE <= 0 || id <= 0 || year <= 0)
                {
                    throw new Exception("Input Valid. Please enter Again.");
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
                return;
            }
           
            Party_BL updated = new Party_BL(txtEditPartyName.Text, id, AGE, txtEditParty.Text, txtEditPartyEmail.Text, year);
            Party_DL.EditUserFromList(previous, updated);
            this.Close();
        }
    }
}
