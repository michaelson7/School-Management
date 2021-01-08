using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace School_Management.Models
{
    public class TeacherModel
    {
        [Display(Name = "Names")]
        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string Names { get; set; }

        [Display(Name = "Lecturer Id")] 
        public int Id { get; set; } 
    }
}
