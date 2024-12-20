using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectoralManagementSystemGUI
{
    public partial class validation18 : Form
    {
        public validation18()
        {
            InitializeComponent();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            castVoteForm vote = new castVoteForm();
            vote.Show();
        }

        private void btnNO_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are not Valid because you are under 18.");
        }
    }
}
