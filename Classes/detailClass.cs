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
        public static string Myconnstrng { get => myconnstrng; set => myconnstrng = value; }

        private static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
    }
}
