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
    public partial class AddCandidateForm : Form
    {
        int AGE, id;
        public AddCandidateForm()
        {
            InitializeComponent();
        }

      
        private void btnAdd_Click(object sender, EventArgs e)
        {

            try
            {
                AGE = int.Parse(txtNewCandidateAge.Text);
                id = int.Parse(txtAddCandidateID.Text);

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
            
            Candidate_BL candidate = new Candidate_BL(txtNewCandidateName.Text,id, AGE, txtNewCandidatePartyName.Text, txtNewCandidateQual.Text, txtNewCandidateCity.Text,  txtNewCandidateStatus.Text);
            Candidate_DL.addCandidateIntoList(candidate);
            this.Close();
        }

     
    }
}
