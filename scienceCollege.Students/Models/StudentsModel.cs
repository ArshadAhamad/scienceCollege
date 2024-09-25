using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace scienceCollege.Students.Models
{
    public class StudentsModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? StudentID { get; set; }
        public string? Department { get; set; }
        public string? Specialization { get; set; }
        public int Year { get; set; }
    }
}
