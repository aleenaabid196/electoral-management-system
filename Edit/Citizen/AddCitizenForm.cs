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
    public partial class AddCitizenForm : Form
    {
        int AGE, id;
        public AddCitizenForm()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                AGE = int.Parse(txtNewCitizenAge.Text);
                id = int.Parse(txtNewCitizenID.Text);
                
                if (AGE <= 0 || id <= 0 )
                {
                    throw new Exception("Input Valid. Please enter Again.");
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
                return;
            }
            
            Citizen_BL citizen = new Citizen_BL(txtNewCitizenName.Text, id, txtNewCitizenCity.Text, AGE, txtNewCitizenStatus.Text);
            Citizen_DL.addCititzenIntoList(citizen);
            this.Close();
        }
    }
}
