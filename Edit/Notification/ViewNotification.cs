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
    public partial class ViewNotification : Form
    {
        public ViewNotification()
        {
            InitializeComponent();
        }

       
        private void linklnlnotify1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FirstNotification n = new FirstNotification();
            n.Show();
        }

        private void linklnlNotify2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SecondNotification s = new SecondNotification();
            s.Show();
        }
    }
}
