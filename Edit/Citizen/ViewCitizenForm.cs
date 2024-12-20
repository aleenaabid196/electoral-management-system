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
    public partial class ViewCitizenForm : Form
    {
        private string path = "citizen.txt";
        public ViewCitizenForm()
        {
            InitializeComponent();
        }

        public void dataBind()
        {
            citizenGV.DataSource = null;
            citizenGV.DataSource = Citizen_DL.citizens;
            citizenGV.Refresh();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Citizen_BL citizen = (Citizen_BL)citizenGV.CurrentRow.DataBoundItem;
            if (citizenGV.Columns["Remove"].Index == e.ColumnIndex)
            {
                Citizen_DL.deleteUserFromList(citizen);
                Citizen_DL.storeAllDataIntoFile(path);
                dataBind();
            }
            else if (citizenGV.Columns["Update"].Index == e.ColumnIndex)
            {
                EditCitizenForm myform = new EditCitizenForm(citizen);
                myform.ShowDialog();
                Citizen_DL.storeAllDataIntoFile(path);
                dataBind();
            }
        }

        private void ViewCitizenForm_Load(object sender, EventArgs e)
        {
            citizenGV.DataSource = null;
            citizenGV.DataSource = Citizen_DL.citizens;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddCitizenForm myForm = new AddCitizenForm();
            myForm.ShowDialog();
            Citizen_DL.storeAllDataIntoFile(path);
            dataBind();
        }
    }
}
