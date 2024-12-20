using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElectoralManagementSystemGUI.BL;
using System.IO;
using ElectoralManagementSystemGUI;

namespace ElectoralManagementSystemGUI.DL
{
    class Party_DL : Person_DL
    {
        public static List<Party_BL> parties = new List<Party_BL>();
        
        public static void addPartyIntoList(Party_BL party)
        {
            parties.Add(party);
        }

        public static void deleteUserFromList(Party_BL party)
        {
            for (int index = 0; index < parties.Count; index++)
            {
                if (parties[index].Name1 == party.Name1 && parties[index].ID1 == party.ID1 && parties[index].Age == party.Age && parties[index].PartyNamesA == party.PartyNamesA  && parties[index].PartyEmailA == party.PartyEmailA && parties[index].PartyYearA == party.PartyYearA)
                {
                    parties.RemoveAt(index);
                }
            }

        }
        public static void EditUserFromList(Party_BL previous, Party_BL updated)
        {
            foreach (Party_BL user in parties)
            {
                if (user.Name1 == previous.Name1 && user.ID1 == previous.ID1 && user.Age == previous.Age && user.PartyNamesA == previous.PartyNamesA && user.PartyEmailA == previous.PartyEmailA && user.PartyYearA == previous.PartyYearA)
                {
                    user.Name1 = updated.Name1;
                    user.ID1 = updated.ID1;
                    user.Age = updated.Age;
                    user.PartyNamesA = updated.PartyNamesA;
                    user.PartyEmailA = updated.PartyEmailA;
                    user.PartyYearA = updated.PartyYearA;
                }
            }

        }


        public static void storeAllDataIntoFile(string path)
        {
            parties = parties.OrderByDescending(o => o.Age).ToList();
            StreamWriter file = new StreamWriter(path);
            foreach (Party_BL storedUser in parties)
            {

                file.WriteLine(storedUser.Name1 + "," + storedUser.ID1 + "," + storedUser.Age + "," + storedUser.PartyNamesA + "," + storedUser.PartyEmailA + "," + storedUser.PartyYearA);
            }
            file.Flush();
            file.Close();

        }

       
        public static void loadPartyData(string path)
        {

            StreamReader fp = new StreamReader(path);
            string record;

            while ((record = fp.ReadLine()) != null)
            {
                if (record.Length != 0)
                {
                    Party_BL c1 = new Party_BL();
                    c1.Name1 = parseRecord(record, 1);
                    c1.ID1 = int.Parse((parseRecord(record, 2)));
                    c1.Age = int.Parse((parseRecord(record, 3)));
                    c1.PartyNamesA = parseRecord(record, 4);
                    c1.PartyEmailA = parseRecord(record, 5);
                    c1.PartyYearA = int.Parse(parseRecord(record, 6));
                    addPartyIntoList(c1);
                }
            }
            parties = parties.OrderByDescending(o => o.Age).ToList();
            fp.Close();
        }
        

    }
}

