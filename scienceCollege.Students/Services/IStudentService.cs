using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace scienceCollege.Students.Services
{
    public interface IStudentService
    {
        List<Models.StudentsModel> GetStudents();
        Models.StudentsModel? GetStudents(int id);
        Models.StudentsModel? AddStudent(Models.StudentsModel student);
        Models.StudentsModel? UpdateStudent(Models.StudentsModel student);
        bool? DeleteStudent(int id);
    }
}
