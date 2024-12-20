using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElectoralManagementSystemGUI.BL;

namespace ElectoralManagementSystemGUI.BL
{
    public class Citizen_BL : Person_BL
    {

        private string citizenCityA;

        private string citizenStatusA;

        public string CitizenCityA { get => citizenCityA; set => citizenCityA = value; }
        public string CitizenStatusA { get => citizenStatusA; set => citizenStatusA = value; }

        public Citizen_BL()
        {
           citizenCityA = "LHR";
        }
        public Citizen_BL (string Name, int ID, string citizenCityA, int age, string citizenStatusA): base( Name,  ID,  age)
        {
            this.citizenCityA = citizenCityA;
            this.citizenStatusA = citizenStatusA;
        }



       
    }
}
