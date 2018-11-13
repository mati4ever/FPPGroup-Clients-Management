using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPPG_ClassLibrary
{
    public static class GlobalConfig
    {
        public static IDataConnector Connection { get; private set; }

        public static void InitializeConnections()
        {
         
                TextConnector text = new TextConnector();
                Connection = text;

           
        }

    }
}
