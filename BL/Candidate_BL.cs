using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElectoralManagementSystemGUI.BL;

namespace ElectoralManagementSystemGUI.BL
{
    public class Candidate_BL : Person_BL
    {

        private string candQualA;
        private string candidateCityA;
        private string candidateStatusA;
        private int candVoteA;


        Party_BL p = new Party_BL();

        public string CandQualA { get => candQualA; set => candQualA = value; }
        public string CandidateCityA { get => candidateCityA; set => candidateCityA = value; }
        public string CandidateStatusA { get => candidateStatusA; set => candidateStatusA = value; }
        public Party_BL party { get => p; set => p = value; }

        

        public int CandVoteA { get => candVoteA; set => candVoteA = value; }
   

        public Candidate_BL()
        {
            this.candVoteA = 0;
            
        }

        public Candidate_BL(string Name, int ID,int age, string partyName, string candQualA, string candidateCityA, string candidateStatusA) : base(Name, ID, age)
        {
            this.CandQualA = candQualA;
            this.p.PartyNamesA = partyName;
            this.candidateStatusA = candidateStatusA;
            this.CandidateCityA = candidateCityA;

        }

       
       
    }
}
