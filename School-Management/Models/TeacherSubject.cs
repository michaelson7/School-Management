using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School_Management.Models
{
    public class TeacherSubject
    {
        public string Id { get; set; }
        public IEnumerable<SelectListItem> Teachers { get; set; }
        public IEnumerable<SelectListItem> Subjects { get; set; }
        public IEnumerable<SelectListItem> Grade { get; set; }
    }
}
