using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElectoralManagementSystemGUI.BL;

namespace ElectoralManagementSystemGUI.BL
{
    class logIN_BL
    {
        private string users;
        private string passwords;
        private string role;

        public string Users { get => users; set => users = value; }
        public string Passwords { get => passwords; set => passwords = value; }
        public string Role { get => role; set => role = value; }

        public logIN_BL()
        {
            this.users = "";
            this.passwords = "";
        }
        public logIN_BL(string users, string passwords)
        {
            this.users = users;
            this.passwords = passwords;
            this.role = "MPA";
        }
        public logIN_BL(string users, string passwords, string role)
        {
            this.users = users;
            this.passwords = passwords;
            this.role = role;
        }
        public logIN_BL(logIN_BL l1)
        {
            users = l1.users;
            passwords = l1.passwords;
        }
        

    }
}
