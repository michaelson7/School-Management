using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School_Management.Models
{
    public class AssignmentSubmissions
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string UploadDate { get; set; }
        public int Grade { get; set; }
        public string Comments { get; set; }
    }
}
