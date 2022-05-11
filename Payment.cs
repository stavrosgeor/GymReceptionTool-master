using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymReceptionTool
{
    class Payment
    {
        public int ID { get; set; }
        public DateTime PTime { get; set; }
        public DateTime PDate { get; set; }
        public int UserID { get; set; }
        public int MemberID { get; set; }
        public int Amount { get; set; }
        public string Note { get; set; }

        public string lbinfo
        {
            get
            {
                return $"({ID}) {Amount} {Note} {PDate}";
            }

        }
    }
}
