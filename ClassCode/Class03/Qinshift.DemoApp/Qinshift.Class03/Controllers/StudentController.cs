using Microsoft.AspNetCore.Mvc;
using Qinshift.Class03.Models.DTOModels;
using Qinshift.Class03.Services;

namespace Qinshift.Class03.Controllers
{
    [Route("students")]
    public class StudentController : Controller
    {
        private StudentService _studentService;

        public StudentController()
        {
            _studentService = new StudentService();
        }

        [HttpGet("{id}")]

        public IActionResult GetStudentById(int id)
        {
            StudentWithCourseDto student = _studentService.GetStudentCourse(id);

            if (student == null)
            {
                return Content($"Student with ID {id} not found.");
            }
            return Json(student);
        }

        [HttpGet("GetAllStudents")]
        public IActionResult GetAllStudents()
        {
            List<ListAllStudentsDto> students = _studentService.GetАllStudents();
            return Json(students);
        }
    }
}
