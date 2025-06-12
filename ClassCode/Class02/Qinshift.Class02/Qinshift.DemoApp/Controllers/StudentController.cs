using Microsoft.AspNetCore.Mvc;
using Qinshift.DemoApp.Models;

namespace Qinshift.DemoApp.Controllers
{
    [Route("students")]
    public class StudentController : Controller
    {
        private List<Student> _students = new List<Student>()
        {
            new() {Id = 1, FirstName = "John", LastName = "Doe"},
            new() {Id = 2, FirstName = "Jane", LastName = "Smith"},
            new() {Id = 3, FirstName = "Alice", LastName = "Johnson"},
        };

        [Route("getAllStudents")]
        public IActionResult GetAll()
        {
            return Json(_students);
        }

        [HttpGet("getAll")]
        public IActionResult GetStudents()
        {
            return Json(_students);
        }

        [HttpGet("getStudentById{id}")]
        public Student GetStudentById(int id)
        {
            return _students.SingleOrDefault(x => x.Id == id);
        }
        [HttpGet("getStudentByIdWithConstraint/{id:int}")]
        public Student GetStudentByIdWithConstraint(int id)
        {
            return _students.SingleOrDefault(x => x.Id == id);
        }
    }
}
