using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElectoralManagementSystemGUI.BL;
using System.IO;

namespace ElectoralManagementSystemGUI.DL
{
    class logIN_DL : Person_DL
    {
        private static List<logIN_BL> usersList = new List<logIN_BL>();

        public static void addUserIntoList(logIN_BL user)
        {
            usersList.Add(user);
        }

        public static logIN_BL SignIn(logIN_BL user)
        {
            foreach (logIN_BL storedUser in usersList)
            {
                if (storedUser.Users == user.Users && storedUser.Passwords == user.Passwords)
                {
                    return storedUser;
                }
            }
            return null;
        }

        //-----------------------FUNCTION TO LOAD LOGIN DATA---------------------------//
        public static bool loadLoginData(string logInPath)
        {

            StreamReader fp = new StreamReader(logInPath);

            string record;
            while ((record = fp.ReadLine()) != null)
            {
                if (record.Length != 0)
                {
                    string user;
                    string password, role;

                    user = parseRecord(record, 1);
                    password = parseRecord(record, 2);
                    role = parseRecord(record, 3);
                    logIN_BL users = new logIN_BL(user, password, role);
                    addUserIntoList(users);

                }
            }
            fp.Close();
            return true;
        }

        //-----------------------FUNCTION TO STORE LOGIN DATA---------------------------//
        public static void storeLoginData(logIN_BL user, string path)
        {

            StreamWriter f1 = new StreamWriter(path, false);
            foreach (logIN_BL suser in usersList)
            {
                f1.WriteLine(suser.Users + "," + suser.Passwords + "," + suser.Role);
            }
            f1.Flush();
            f1.Close();
        }


       
    }
}
