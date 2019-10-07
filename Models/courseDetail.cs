using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Inghram_MIS_4200.Models
{
    public class courseDetail
    {
        [Display(Name = "Course Detail ID")]
        [Required(ErrorMessage = "Course Detail ID is Required")]
        public int courseDetailID { get; set; }

        [Display(Name = "Course Description")]
        [Required(ErrorMessage = "Course Description is Required")]
        [StringLength(20)]
        public string courseDescription { get; set; }
        [Display(Name = "Course Date and Time")]
        [Required(ErrorMessage = "Course Date and Time is Required")]
        public DateTime courseTime { get; set; }
        [Display(Name = "Course Number")]
        [Required(ErrorMessage = "Course Number is Required")]
        public int courseID { get; set; }
        [Display(Name = "Student Number")]
        [Required(ErrorMessage = "Student Number is Required")]
        public int studentID { get; set; }
        public virtual course course { get; set; }
        public virtual student student { get; set; }

    }
}