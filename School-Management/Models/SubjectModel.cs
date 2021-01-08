using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace School_Management.Models
{
    public class SubjectModel
    {
        [Display(Name = "Names")] 
        public int Id { get; set; }
        [Display(Name = "Title")]
        public string Title { get; set; }
        [Display(Name = "Grade")]
        public string Grade { get; set; } 
        [Display(Name = "Teachers")]
        public List<SelectListItem> Teacher { get; set; } = new List<SelectListItem>();
    }
}
