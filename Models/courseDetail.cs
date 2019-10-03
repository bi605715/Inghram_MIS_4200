using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inghram_MIS_4200.Models
{
    public class courseDetail
    {
        [Display(Name = "Course Detail ID")]
        public int courseDetailID { get; set; }
        [Display(Name = "Course Description")]
        public string courseDescription { get; set; }
        [Display(Name = "Course Date and Time")]
        public DateTime courseTime { get; set; }

        public int courseID { get; set; }
        public int studentID { get; set; }
        public virtual course course { get; set; }
        public virtual student student { get; set; }

    }
}