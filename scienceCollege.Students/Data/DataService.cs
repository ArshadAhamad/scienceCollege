using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace scienceCollege.Students.Data
{
    public class DataService
    {
        public static List<Models.StudentsModel> Students = new List<Models.StudentsModel>()
        {
            new Models.StudentsModel {Id = 1, Name = "Ishara", StudentID = "IT1919", Department = "FOC", Specialization = "IT", Year = 4 },
            new Models.StudentsModel {Id = 2, Name ="Kavindya", StudentID = "IT2021", Department = "FOC", Specialization = "SE", Year = 4 },
            new Models.StudentsModel {Id = 3, Name ="Arshad", StudentID = "IT2023", Department = "FOC", Specialization = "IT", Year = 4 },
            new Models.StudentsModel {Id = 4, Name ="Maleesha", StudentID = "IT2121", Department = "FOC", Specialization = "SE", Year = 4 },
        };
    }
}
