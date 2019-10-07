using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.ComponentModel;


namespace Inghram_MIS_4200.Models
{
    public class course
    {
        [Key]
        [Display(Name = "Course Number")]
        [Required(ErrorMessage = "Course Number is Required")]
        public int courseID { get; set; }
        [Display(Name = "Number of Courses")]
        [Required(ErrorMessage = "Number of Courses is Required")]
        public int courses { get; set; }
        [Display(Name = "Course Title")]
        [Required(ErrorMessage = "Course Title is Required")]
        [StringLength(20)]
        public string courseName { get; set; }
        [Display(Name = "Professor First Name")]
        [Required(ErrorMessage = "Professor First Name is Required")]
        [StringLength(20)]

        public string professorfirstName { get; set; }
        [Display(Name = "Professor Last Name")]
        [Required(ErrorMessage = "Professor Last Name is Required")]
        [StringLength(20)]
        public string professorlastName { get; set; }
        [Display(Name = "Course Date and Time")]
        [Required(ErrorMessage = "Course Date and Time is Required")]

        public DateTime courseTime { get; set; }

        public ICollection<courseDetail> courseDetails { get; set; }

        [Display(Name = "Student")]

        public int student { get; set; }



    }
}