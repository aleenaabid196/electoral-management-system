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
    
    public partial class ElectionResult : Form
    {
        private string path = "candidate.txt";
        public ElectionResult()
        {
            InitializeComponent();
        }

        private void ElectionResult_Load(object sender, EventArgs e)
        {
            vieResultGV.DataSource = null;
            vieResultGV.DataSource = Candidate_DL.Candidates.Select(c => new {
                c.Name1,
                c.ID1,
                c.Age,
                c.party.PartyNamesA,
                c.CandQualA,
                c.CandidateCityA,
                c.CandidateStatusA, c.CandVoteA
            }).ToList(); ;
        }
        public void dataBind()
        {
            vieResultGV.DataSource = null;
            vieResultGV.DataSource = Candidate_DL.Candidates.Select(c => new {
                c.Name1,
                c.ID1,
                c.Age,
                c.party.PartyNamesA,
                c.CandQualA,
                c.CandidateCityA,
                c.CandidateStatusA, c.CandVoteA
            }).ToList(); ;
            vieResultGV.Refresh();
        }
    }
}
