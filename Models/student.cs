using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Inghram_MIS_4200.Models
{
    public class student
    {
        [Display(Name = "Student Number")]
        [Required(ErrorMessage = "Student Number is Required")]
        public int studentID { get; set; }
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "First Name is Required")]
        [StringLength(20)]
        public string firstName { get; set; }
        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Last Name is Required")]
        [StringLength(20)]
        public string lastName { get; set; }
        [Display(Name = "Phone Number")]
        [Required(ErrorMessage = "Phone Number is Required")]
        public string phone { get; set; }
        [Display(Name = "Email Address")]
        [Required(ErrorMessage = "Email Address is Required")]
        public string email { get; set; }
        public ICollection<course> Course { get; set; }

        
    }
}