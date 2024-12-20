using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElectoralManagementSystemGUI.BL;

namespace ElectoralManagementSystemGUI.BL
{
    public class Person_BL
    {
        private string Name;
        private int age;
        private int ID;

        public string Name1 { get => Name; set => Name = value; }
        public int Age { get => age; set => age = value; }
        public int ID1 { get => ID; set => ID = value; }

        public Person_BL()
        {

        }
        public Person_BL(string Name, int ID, int age)
        {
            this.Name1 = Name;
            this.Age = age;
            this.Age = age;
        }
      
    }
}
