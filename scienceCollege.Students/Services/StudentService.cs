using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using scienceCollege.Students.Data;
using scienceCollege.Students.Models;

namespace scienceCollege.Students.Services
{
    public class StudentService:IStudentService
    {
        public List<Models.StudentsModel> GetStudents()
        {
            return DataService.Students;

        }
        public Models.StudentsModel? GetStudents(int id)
        {
            return DataService.Students.FirstOrDefault(x => x.Id == id);
        }
        public Models.StudentsModel? AddStudent(Models.StudentsModel student)
        {
            DataService.Students.Add(student);
            return student;
        }
        public Models.StudentsModel? UpdateStudent(Models.StudentsModel student)
        {
            Models.StudentsModel selectedStudent = DataService.Students.FirstOrDefault(x => x.Id == student.Id);
            if (selectedStudent != null)
            {
                selectedStudent.Name = student.Name;
                selectedStudent.StudentID = student.StudentID;
                selectedStudent.Department = student.Department;
                selectedStudent.Specialization = student.Specialization;
                selectedStudent.Year = student.Year;
                return selectedStudent;
            }

            return selectedStudent;
        }

        public bool? DeleteStudent(int id)
        {
            Models.StudentsModel selectedStudent = DataService.Students.FirstOrDefault(x => x.Id == id);
            if (selectedStudent != null)
            {
                DataService.Students.Remove(selectedStudent);
                return true;
            }
            return false;
        }
    }
}
