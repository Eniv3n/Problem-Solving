using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FORMUI
{
    public static class Helper
    {
        // Retrives the Connection String from the App.config and passes it along, to avoid hard-coding 
        public static string CnnVal(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
