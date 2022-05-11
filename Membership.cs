using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymReceptionTool
{
    class Membership
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int MembershipAmount { get; set; }
        public int UserCreated { get; set; }
        public int MembershipPeriod { get; set; }

        public string FullInfo
        {
            get
            {
                return $"({ID}) {Name} {MembershipAmount}";
            }

        }
    }
}
