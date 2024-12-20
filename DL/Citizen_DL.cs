using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElectoralManagementSystemGUI.BL;
using System.IO;

namespace ElectoralManagementSystemGUI.DL
{
    class Citizen_DL : Person_DL
    {
       public static List<Citizen_BL> citizens = new List<Citizen_BL>();

        public static void addCititzenIntoList(Citizen_BL citizen)
        {
            citizens.Add(citizen);
        }

        public static void deleteUserFromList(Citizen_BL citizen)
        {
            for (int index = 0; index < citizens.Count; index++)
            {
                if (citizens[index].Name1 == citizen.Name1 && citizens[index].ID1 == citizen.ID1 && citizens[index].CitizenCityA == citizen.CitizenCityA && citizens[index].Age == citizen.Age && citizens[index].CitizenStatusA == citizen.CitizenStatusA)
                {
                    citizens.RemoveAt(index);
                }
            }

        }
        public static void EditUserFromList(Citizen_BL previous, Citizen_BL updated)
        {
            foreach (Citizen_BL user in citizens)
            {
                if (user.Name1 == previous.Name1 && user.ID1 == previous.ID1 && user.CitizenCityA == previous.CitizenCityA && user.Age == previous.Age && user.CitizenStatusA == previous.CitizenStatusA)
                {
                    user.Name1 = updated.Name1;
                    user.ID1 = updated.ID1;
                    user.CitizenCityA = updated.CitizenCityA;
                    user.Age = updated.Age;
                    user.CitizenStatusA = updated.CitizenStatusA;
                }
            }

        }
        

        
        public static void storeAllDataIntoFile(string path)
        {
            citizens = citizens.OrderByDescending(o => o.Age).ToList();
            StreamWriter file = new StreamWriter(path);
            foreach (Citizen_BL storedUser in citizens)
            {

                file.WriteLine(storedUser.Name1 + "," + storedUser.ID1 + "," + storedUser.CitizenCityA + "," + storedUser.Age + "," + storedUser.CitizenStatusA);
            }
            file.Flush();
            file.Close();

        }

       
        public static void loadCitizenData(string path)
        {
            
            StreamReader fp = new StreamReader(path);
            string record;

            while ((record = fp.ReadLine()) != null)
            {
                if (record.Length != 0)
                {
                    Citizen_BL c1 = new Citizen_BL();
                    c1.Name1 = parseRecord(record, 1);
                    c1.ID1 = int.Parse((parseRecord(record, 2)));
                    c1.CitizenCityA = parseRecord(record, 3);
                    c1.Age = int.Parse((parseRecord(record, 4)));
                    c1.CitizenStatusA = parseRecord(record, 5);
                    addCititzenIntoList(c1);
                }
            }
            citizens = citizens.OrderByDescending(o => o.Age).ToList();
            fp.Close();
        }
       


       

    }
}
