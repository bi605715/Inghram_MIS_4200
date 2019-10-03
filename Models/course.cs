using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace Inghram_MIS_4200.Models
{
    public class course
    {
        [Key]
        [Display (Name ="Course Number")]
        public int courseID { get; set; }
        [Display(Name = "Number of Courses")]
        public int courses { get; set; }
        [Display(Name = "Course Title")]
        public string courseName { get; set; }
        [Display(Name = "Professor First Name")]

        public string professorfirstName { get; set; }
        [Display(Name = "Professor Last Name")]
        public string professorlastName { get; set; }
        [Display(Name = "Course Date and Time")]
        public DateTime courseTime { get; set; }

        public ICollection<courseDetail> courseDetails { get; set; }

        [Display(Name = "Student")]

        public int student { get; set; }



    }
}