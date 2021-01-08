using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School_Management.Models
{
    public class AssignmentModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Grade { get; set; }
        public string Deadline { get; set; }

        public string File { get; set; }
    }
}
