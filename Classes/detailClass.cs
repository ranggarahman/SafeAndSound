using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafeAndSound.Classes
{
    class detailClass
    {
        public int ContactID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNumber { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }

        public static class ConfigurationConst
        {
            public static KeyValueConfigurationCollection Configs;
        }
        internal class ApplicationConfigurationReader
        {
            public void Read()
            {
                // read assembly
                var ExecAppPath = this.GetType().Assembly.Location;

                // Get all app settings  in config file
                ConfigurationConst.Configs = ConfigurationManager.OpenExeConfiguration(ExecAppPath).AppSettings.Settings;
            }
        }
        public string myconnstrng = ConfigurationManager.ConnectionStrings["connstrg"].ConnectionString;
    }
}
