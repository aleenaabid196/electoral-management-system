using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ElectoralManagementSystemGUI.BL;
using ElectoralManagementSystemGUI.DL;

namespace ElectoralManagementSystemGUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Candidate_DL.loadCandidateData("candidate.txt");
            Citizen_DL.loadCitizenData("citizen.txt");
            Party_DL.loadPartyData("party.txt");
            

            Application.Run(new FormSignInSignUp());
        }
    }
}
