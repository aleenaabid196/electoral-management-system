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
    public partial class EditCandidateForm : Form
    {
        private Candidate_BL previous;
        int AGE, id;
        public EditCandidateForm(Candidate_BL previous)
        {
            InitializeComponent();
            this.previous = previous;
        }

        private void EditCandidateForm_Load(object sender, EventArgs e)
        {
            txtEditCandidateName.Text = previous.Name1;
            txtEditCandidateID.Text = previous.ID1.ToString();
            txtEditCandidateAge.Text = previous.Age.ToString();
            txtEditCandidatePartyName.Text = previous.party.PartyNamesA;
            txtEditCandidateQual.Text = previous.CandQualA;
            txtEditCandidateCity.Text = previous.CandidateCityA;
            txtEditCandidateStatus.Text = previous.CandidateStatusA;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                AGE = int.Parse(txtEditCandidateAge.Text);
                id = int.Parse(txtEditCandidateID.Text);

                if (AGE <= 0 || id <= 0)
                {
                    throw new Exception("Input Valid. Please enter Again.");
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
                return;
            }
           
            Candidate_BL updated = new Candidate_BL(txtEditCandidateName.Text, id, AGE, txtEditCandidatePartyName.Text,txtEditCandidateQual.Text,txtEditCandidateCity.Text, txtEditCandidateStatus.Text);
            Candidate_DL.EditUserFromList(previous, updated);
            this.Close();
        }
    }
}
