using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymReceptionTool
{
    class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Tel { get; set; }
        public DateTime DateAdded { get; set; }
        public string Address { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FullInfo
        {
            get { 
                return $"({ID}) {Name} {Tel}";
            }
            
        }


    }
}
