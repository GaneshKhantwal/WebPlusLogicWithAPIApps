using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebPlusLogicWithAPIApps.Business
{
    public class DBConnection
    {
        private static string connectionstring;

        public static string ConnectionString
        {
            get {
                connectionstring = ConfigurationManager.ConnectionStrings["DBConnection"].ToString();
                return connectionstring; 
            }
            set { connectionstring = value; }
        }
       
    }
}
