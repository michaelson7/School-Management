using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace School_Management.Models
{
    public class StudentModel
    {
        [Display(Name = "StudentID")] 
        public int StudentID { get; set; }

        [Display(Name = "First Name")]
        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string LastName { get; set; }

        [Display(Name = "Phone Number")]
        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string PhoneNumber { get; set; }

        [Display(Name = "Email Address")]
        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string Email { get; set; }

        [Display(Name = "Password")]
        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string Password { get; set; }

        [Display(Name = "Gender")]
        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string Gender { get; set; }

        [Display(Name = "Local Address")]
        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string Address { get; set; }

        [Display(Name = "Grade")]
        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string Grade { get; set; }

        [Display(Name = "Academic Year")]
        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string AcademkicYear { get; set; }


    }
}
