using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using scienceCollege.Students.Services;
using scienceCollege.Students.Data;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace scienceCollege.Students.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService ?? throw new ArgumentNullException(nameof(studentService));
        }


        /// <summary>
        /// Get all students
        /// </summary>
        /// <returns>return the list of students</returns>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_studentService.GetStudents());
        }

        /// <summary>
        /// Get student by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Return the student with the passed ID</returns>
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {


            return _studentService.GetStudents(id) != null ? Ok(_studentService.GetStudents(id)) : NoContent();
           


        }

        /// <summary>
        /// Add students
        /// </summary>
        /// <param name="student"></param>
        /// <returns>Return the added student</returns>
        [HttpPost]
        public IActionResult Post([FromBody] Models.StudentsModel student)
        {
            return Ok(_studentService.AddStudent(student));
        }

        /// <summary>
        /// Update the student
        /// </summary>
        /// <param name="student"></param>
        /// <returns>Return the updated student</returns>
        [HttpPut]
        public IActionResult Put([FromBody] Models.StudentsModel student)
        {
            return Ok(_studentService.UpdateStudent(student));
        }

        /// <summary>
        /// Delete the student with the passed ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
           

            

            var result = _studentService.DeleteStudent(id);
            return result.HasValue & result == true ? Ok($"student with ID:{id} got deleted successfully.")
               : BadRequest($"Unable to delete the student with ID:{id}.");
        }
    }
}
