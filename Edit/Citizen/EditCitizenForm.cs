using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElectoralManagementSystemGUI.BL;
using ElectoralManagementSystemGUI.DL;
using System.Windows.Forms;

namespace ElectoralManagementSystemGUI
{
    public partial class EditCitizenForm : Form
    {
        int AGE, id;
        private Citizen_BL previous;
        public EditCitizenForm(Citizen_BL previous)
        {
            InitializeComponent();
            this.previous = previous;
        }

        private void EditCitizenForm_Load(object sender, EventArgs e)
        {

            txtEditCitizenName.Text = previous.Name1;
            txtEditCitizenStatus.Text = previous.CitizenStatusA;
            txtEditCitizenID.Text = previous.ID1.ToString();
            txtEditCitizenCity.Text = previous.CitizenCityA;
            txtEditCitizenAge.Text = previous.Age.ToString();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                AGE = int.Parse(txtEditCitizenAge.Text);
                id = int.Parse(txtEditCitizenID.Text);

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
            
            Citizen_BL updated = new Citizen_BL(txtEditCitizenName.Text, id, txtEditCitizenCity.Text, AGE, txtEditCitizenStatus.Text);
            Citizen_DL.EditUserFromList(previous, updated);
            this.Close();
        }

     
    }
}
