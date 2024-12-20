using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElectoralManagementSystemGUI.BL;

namespace ElectoralManagementSystemGUI.BL
{
    public class Party_BL : Person_BL
    {
        private string partyNamesA;
        private string partyEmailA;
        private int partyYearA;

        public string PartyNamesA { get => partyNamesA; set => partyNamesA = value; }
        public string PartyEmailA { get => partyEmailA; set => partyEmailA = value; }
        public int PartyYearA { get => partyYearA; set => partyYearA = value; }

        public Party_BL()
        {
            partyNamesA = "Ali";
        }
        public Party_BL(string Name, int ID, int age, string partyNamesA,  string partyEmailA, int partyYearA) : base(Name, ID, age)
        {
            this.partyNamesA = partyNamesA;
            this.partyEmailA = partyEmailA;
            this.partyYearA = partyYearA;
        }


        
    }
}
