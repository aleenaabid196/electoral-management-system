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
    public partial class castVoteForm : Form
    {
        private string path = "candidate.txt";
        bool click = true;
        CheckBox lastChecked;
        public castVoteForm()
        {
            InitializeComponent();
        }
        public void dataBind()
        {
            castVoteGV.DataSource = null;
            castVoteGV.DataSource = Candidate_DL.Candidates.Select(c => new {
                c.Name1
            ,
                c.ID1,
                c.Age,
                c.party.PartyNamesA,
                c.CandQualA,
                c.CandidateCityA,
                c.CandidateStatusA, c.CandVoteA
            }).ToList(); ;

            castVoteGV.Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {/*
            CheckBox activeCheckBox = sender as CheckBox;
            if (activeCheckBox != lastChecked && lastChecked != null) lastChecked.Checked = false;
            lastChecked = activeCheckBox.Checked ? activeCheckBox : null;

            if (castVoteGV.Columns["Vote"].Index == e.ColumnIndex && click)
            {
                Candidate_BL candidate = (Candidate_BL)castVoteGV.CurrentRow.DataBoundItem;
                int index = castVoteGV.CurrentRow.Index;
                candidate.CandVoteA++;
                Candidate_DL.Candidates[index].CandVoteA++;
                Candidate_DL.storeAllDataIntoFile(path);
                click = false;
            }*/

            const int chkBoxColumnIndex = 0;

            var dataGridView = (DataGridView)sender;

            if (e.ColumnIndex == chkBoxColumnIndex)
            {
                dataGridView.EndEdit();

                var isChecked = (bool)dataGridView[e.ColumnIndex, e.RowIndex].Value;

                if (isChecked)
                {
                    foreach (DataGridViewRow row in dataGridView.Rows)
                    {
                        if (row.Index != e.RowIndex)
                            row.Cells[chkBoxColumnIndex].Value = !isChecked;
                        else
                            Candidate_DL.Candidates[e.RowIndex].CandVoteA++;

                    }
                }
            }

        }

        
        

        private void castVoteForm_Load(object sender, EventArgs e)
        {
            castVoteGV.DataSource = null;
           castVoteGV.DataSource = Candidate_DL.Candidates.Select(c => new {
                c.Name1,
                c.ID1,
                c.Age,
                c.party.PartyNamesA,
                c.CandQualA,
                c.CandidateCityA,
                c.CandidateStatusA, c.CandVoteA
            }).ToList(); ;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

           int c= castVoteGV.Columns.Count;
            

        }
    }
}
