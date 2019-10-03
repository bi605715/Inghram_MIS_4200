using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inghram_MIS_4200.Models
{
    public class student
    {
        public int studentID { get; set; }
        [Display(Name = "First Name")]
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public ICollection<course> Course { get; set; }

        
    }
}