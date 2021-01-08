using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School_Management.Models
{
    public class AttendanceModel
    {
        public int Id { get; set; }
        public IEnumerable<SelectListItem> Student { get; set; }
        public IEnumerable<SelectListItem> Subject { get; set; }
        public IEnumerable<SelectListItem> Grades { get; set; } 
    }
}
