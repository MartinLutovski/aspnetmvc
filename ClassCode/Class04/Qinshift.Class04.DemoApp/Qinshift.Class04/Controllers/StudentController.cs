using Microsoft.AspNetCore.Mvc;
using Qinshift.Class04.Models.DtoModel;
using Qinshift.Class04.Models.ViewModels;

namespace Qinshift.Class04.Controllers
{

    [Route("[Controller]")]
    public class StudentController : Controller
    {
        private readonly Services.StudentService _studentService;

        public StudentController()
        {
            _studentService = new Services.StudentService();
        }

        public IActionResult GetAllStudents()
        {
            List<StudentWithCourseDto> students = _studentService.GetAllStudents();
            return View(students);
        }

        [HttpGet("{id}")]
        public IActionResult GetStudentById(int id)
        {
            StudentWithCourseDto student = _studentService.GetStudentById(id);
            
            return View(student);
        }

        [HttpGet("createStudent")]
        public IActionResult CreateStudent()
        {
            return View();
        }   

        [HttpPost("createStudent")]
        public IActionResult CreateStudent(CreateStudentVM createStudentVM)
        {
            _studentService.CreateStudent(createStudentVM);
            return RedirectToAction("GetAllStudents");
        }
    }
}
