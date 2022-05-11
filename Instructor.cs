using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymReceptionTool
{
    class Instructor
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Tel { get; set; }
        public string email { get; set; }
        public string Address { get; set; }
        public int UserRegistered { get; set; }

        public string lbInfo
        {
            get
            {
                return $"({ID}) {Name} {Surname} ";
            }

        }
    }

}
