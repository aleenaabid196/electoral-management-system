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
    public partial class voterMenuForm : Form
    {
        int imageNumber = 1;
        public voterMenuForm()
        {
            InitializeComponent();
        }

        

        private void cASTVOTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            validation18 val = new validation18();
            val.Show();
            
        }

        private void honourableECEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutCECForm c = new aboutCECForm();
            c.Show();
        }

        private void newsLetterPublicationsMenuItem_Click(object sender, EventArgs e)
        {
            NewsLetter n = new NewsLetter();
            n.Show();
        }

        private void notificationsMenuItem_Click(object sender, EventArgs e)
        {
            ViewNotification notification = new ViewNotification();
            notification.Show();
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

        private void faqsMenuItem_Click(object sender, EventArgs e)
        {
            FAQsForm faq = new FAQsForm();
            faq.Show();
        }

        private void listOfPoliticalPartiesMenuItem_Click(object sender, EventArgs e)
        {
            listPloiticalPartyForm p = new listPloiticalPartyForm();
            p.Show();
        }

        private void contactUsMenuItem_Click(object sender, EventArgs e)
        {
            contactForm cnt = new contactForm();
            cnt.Show();
        }

       
    }
}
