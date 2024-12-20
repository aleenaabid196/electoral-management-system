using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElectoralManagementSystemGUI.BL;
using System.IO;

namespace ElectoralManagementSystemGUI.DL
{
    class Candidate_DL : Person_DL
    {

        private static List<Candidate_BL> candidates = new List<Candidate_BL>();

        public static List<Candidate_BL> Candidates { get => candidates; set => candidates = value; }

        //-----------------------CANDIDATE MENU---------------------------//
        public static void loadCandidateData(string path)
        {

            StreamReader fp = new StreamReader(path);
            string record;
            
           
           
            
            while ((record = fp.ReadLine()) != null)
            {
                
                if (record.Length != 0)
                {
                    Candidate_BL c1 = new Candidate_BL();
                    c1.Name1 = parseRecord(record, 1);
                    c1.ID1 = int.Parse((parseRecord(record, 2)));
                    c1.Age = int.Parse((parseRecord(record, 3)));
                    c1.party.PartyNamesA = parseRecord(record, 4);
                    c1.CandQualA = parseRecord(record, 5);
                    c1.CandidateCityA = parseRecord(record, 6);
                    c1.CandidateStatusA = parseRecord(record, 7);
                    c1.CandVoteA = int.Parse(parseRecord(record, 8));
                    addCandidateIntoList(c1);
                }

            }
            candidates = candidates.OrderByDescending(o => o.Age).ToList();
            fp.Close();
        }
        public static void addCandidateIntoList(Candidate_BL candidate)
        {
            candidates.Add(candidate);
        }

        public static void deleteUserFromList(Candidate_BL candidate)
        {
            for (int index = 0; index < candidates.Count; index++)
            {
                if (candidates[index].Name1 == candidate.Name1 && candidates[index].ID1 == candidate.ID1 && candidates[index].Age == candidate.Age && candidates[index].party.PartyNamesA == candidate.party.PartyNamesA && candidates[index].CandQualA == candidate.CandQualA && candidates[index].CandidateCityA== candidate.CandidateCityA && candidates[index].CandidateStatusA == candidate.CandidateStatusA)
                {
                    candidates.RemoveAt(index);
                }
            }

        }
        public static void storeAllDataIntoFile(string path)
        {
            candidates = candidates.OrderByDescending(o => o.Age).ToList();
            StreamWriter file = new StreamWriter(path);
            foreach (Candidate_BL storedUser in candidates)
            {

                file.WriteLine(storedUser.Name1 + "," + storedUser.ID1 + "," + storedUser.Age + "," + storedUser.party.PartyNamesA + "," + storedUser.CandQualA + "," + storedUser.CandidateCityA +","+ storedUser.CandidateStatusA+ "," + storedUser.CandVoteA);
            }
            file.Flush();
            file.Close();

        }

       
      
        public static void EditUserFromList(Candidate_BL previous, Candidate_BL updated)
        {
            foreach (Candidate_BL user in candidates)
            {
                if (user.Name1 == previous.Name1 && user.ID1 == previous.ID1 && user.Age == previous.Age && user.party.PartyNamesA == previous.party.PartyNamesA && user.CandQualA == previous.CandQualA && user.CandidateCityA == previous.CandidateCityA && user.CandidateStatusA == previous.CandidateStatusA)
                {
                    user.Name1 = updated.Name1;
                    user.ID1 = updated.ID1;
                    user.CandidateCityA = updated.CandidateCityA;
                    user.Age = updated.Age;
                    user.CandidateStatusA =  updated.CandidateStatusA;
                    user.party.PartyNamesA = updated.party.PartyNamesA;
                    user.CandQualA = updated.CandQualA;
                }
            }

        }
       
       
        

    }
}
