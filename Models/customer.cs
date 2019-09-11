using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inghram_MIS_4200.Models
{
    public class customer
    {
        public int customerID { get; set; }
        public int firstName { get; set; }
        public int lastName { get; set; }
        public int phone { get; set; }
        public int email { get; set; }
        public ICollection<order> orders { get; set; }
    }
}