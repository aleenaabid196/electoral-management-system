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
    public partial class adminMenuForm : Form
    {
        
        public adminMenuForm()
        {
            InitializeComponent();
        }
        int imageNumber = 1;
        private void citizenMenuItem_Click(object sender, EventArgs e)
        {
            ViewCitizenForm citizen = new ViewCitizenForm();
            citizen.Show();
        }

        private void candidateMenuItem_Click(object sender, EventArgs e)
        {
            candidateMenuForm candidate = new candidateMenuForm();
            candidate.Show();
        }

        private void votersMenuItem_Click(object sender, EventArgs e)
        {
            partyMenuForm party = new partyMenuForm();
            party.Show();
        }

        private void notificationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewNotification notification = new ViewNotification();
            notification.Show();
        }

        private void newsLetterPublicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewsLetter n = new NewsLetter();
            n.Show();
        }

        private void honourableECEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutCECForm c = new aboutCECForm();
            c.Show();
        }

        private void viewElectionResultMenuItem_Click(object sender, EventArgs e)
        {
            ElectionResult result = new ElectionResult();
            result.Show();

        }

        private void tmrChangeImage_Tick(object sender, EventArgs e)
        {
            slierPictureBox.Image = imageList1.Images[imageNumber];
            if (imageNumber == imageList1.Images.Count - 1)
            {
                imageNumber = 0;
            }
            else
            {
                imageNumber++; 
            }

        }

       
    }
}
