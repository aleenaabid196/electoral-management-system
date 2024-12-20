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
    public partial class candidateMenuForm : Form
    {
       
        private string path = "candidate.txt";
        public candidateMenuForm()
        {
            InitializeComponent();
        }
        public void dataBind()
        {
            candidateGV.DataSource = null;
            candidateGV.DataSource = Candidate_DL.Candidates.Select(c => new { c.Name1
            ,c.ID1, c.Age, c.party.PartyNamesA, c.CandQualA, c.CandidateCityA, c.CandidateStatusA,
                c.CandVoteA
            }).ToList();


                candidateGV.Refresh();
        }

       

        private void candidateMenuForm_Load(object sender, EventArgs e)
        {
            dataBind();
        }

        private void citizenGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Candidate_BL candidate = (Candidate_BL)candidateGV.CurrentRow.DataBoundItem;
        
            if (candidateGV.Columns["Remove"].Index == e.ColumnIndex)
            {
                Candidate_DL.deleteUserFromList(candidate);
                Candidate_DL.storeAllDataIntoFile(path);
                dataBind();
            }
            else if (candidateGV.Columns["Update"].Index == e.ColumnIndex)
            {
                EditCandidateForm myform = new EditCandidateForm(candidate);
                myform.ShowDialog();
                Candidate_DL.storeAllDataIntoFile(path);
                dataBind();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddCandidateForm myForm = new AddCandidateForm();
            myForm.ShowDialog();
            Candidate_DL.storeAllDataIntoFile(path);
            dataBind();
        }
    }
}
