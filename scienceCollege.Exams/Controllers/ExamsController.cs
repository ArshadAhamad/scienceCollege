using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using scienceCollege.Exams.Services;
using scienceCollege.Exams.Data;
using System.Reflection;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace scienceCollege.Exams.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExamsController : ControllerBase
    {
        private readonly IExamService _examService;

        public ExamsController(IExamService examService)
        {
            _examService = examService ?? throw new ArgumentNullException(nameof(ExamService));
        }


        /// <summary>
        /// Get all students
        /// </summary>
        /// <returns>return the list of students</returns>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_examService.GetExams());
        }

        /// <summary>
        /// Get student by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Return the student with the passed ID</returns>
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {


            return _examService.GetExams(id) != null ? Ok(_examService.GetExams(id)) : NoContent();



        }

        /// <summary>
        /// Add students
        /// </summary>
        /// <param name="student"></param>
        /// <returns>Return the added student</returns>
        [HttpPost]
        public IActionResult Post([FromBody] Modles.ExamModel exam)
        {
            return Ok(_examService.AddExams(exam));
        }

        /// <summary>
        /// Update the student
        /// </summary>
        /// <param name="student"></param>
        /// <returns>Return the updated student</returns>
        [HttpPut]
        public IActionResult Put([FromBody] Modles.ExamModel exam)
        {
            return Ok(_examService.UpdateExams(exam));
        }

        /// <summary>
        /// Delete the student with the passed ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {




            var result = _examService.DeleteExams(id);
            return result.HasValue & result == true ? Ok($"Exam with ID:{id} got deleted successfully.")
               : BadRequest($"Unable to delete the exam with ID:{id}.");
        }
    }
}
