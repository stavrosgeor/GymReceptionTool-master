using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymReceptionTool
{
    class Member
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime JoinDate { get; set; }
        public DateTime MembershipExp{ get; set; }
        public int Age { get; set; }
        public string Tel { get; set; }
        public string email { get; set; }
        public int Balance { get; set; }
        public string Gender { get; set; }
        public int UserRegistered { get; set; }
        public int Instructor { get; set; }
        public int MembershipID { get; set; }
        public string Address { get; set; }
        public string FullInfo
        {
            get
            {
                return $"({ID}) {Name} {Surname} {Tel}";
            }

        }

        public string onPremises
        {
            get
            {
                return $"({ID}) {Name} {Surname}";
            }

        }


    }
}
