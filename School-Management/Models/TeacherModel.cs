using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace School_Management.Models
{
    public class TeacherModel
    {
        public int Id { get; set; }
        public string Names { get; set; }
        public string DOB { get; set; }
        public string Qualification { get; set; }
        public string Email { get; set; }
        public string NRC { get; set; }
        public string Salary { get; set; }
        public string PhoneNumber { get; set; }
        public IEnumerable<SelectListItem> SubjectsTeaching { get; set; }
    }
}
