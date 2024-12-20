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
    public partial class NewsLetter : Form
    {
        public NewsLetter()
        {
            InitializeComponent();
        }

        private void linklnlnotify1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FirstNewsLetter newsLetter = new FirstNewsLetter();
            newsLetter.Show();
        }

        private void linklnlNotify2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SecondNewsLetter newsLetter = new SecondNewsLetter();
            newsLetter.Show();
        }
    }
}
