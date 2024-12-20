using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ElectoralManagementSystemGUI.BL;
using ElectoralManagementSystemGUI.DL;

namespace ElectoralManagementSystemGUI
{
    public partial class partyMenuForm : Form
    {
        private string path = "party.txt";
        public partyMenuForm()
        {
            InitializeComponent();
        }
        public void dataBind()
        {
            partyGV.DataSource = null;
            partyGV.DataSource = Party_DL.parties;
            partyGV.Refresh();
        }
        private void partyMenuForm_Load(object sender, EventArgs e)
        {
            partyGV.DataSource = null;
            partyGV.DataSource = Party_DL.parties;
        }

        private void partyGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Party_BL party = (Party_BL)partyGV.CurrentRow.DataBoundItem;
            if (partyGV.Columns["Remove"].Index == e.ColumnIndex)
            {
                Party_DL.deleteUserFromList(party);
                Party_DL.storeAllDataIntoFile(path);
                dataBind();
            }
            else if (partyGV.Columns["Update"].Index == e.ColumnIndex)
            {
                EditPartyForm myform = new EditPartyForm(party);
                myform.ShowDialog();
                Party_DL.storeAllDataIntoFile(path);
                dataBind();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddPartyForm myForm = new AddPartyForm();
            myForm.ShowDialog();
            Party_DL.storeAllDataIntoFile(path);
            dataBind();
        }
    }
}
