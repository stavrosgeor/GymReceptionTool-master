using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymReceptionTool
{
    public static class Helper
    {
        public static string cnnstring(string name)
        {

            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
