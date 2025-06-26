using Avenga.Class07.ModelBinding.Models.Dtos;
using Avenga.Class07.ModelBinding.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Avenga.Class07.ModelBinding.Controllers
{
    public class StudentController : Controller

    {
        private List<StudentDto> _students;
        public StudentController()
        {
            _students = new List<StudentDto>
            {
                new StudentDto
                {
                    Id = 1,
                    FullName = "Bob Bobsky",
                    Age = 33
                },
                new StudentDto
                {
                    Id = 2,
                    FullName = "Jill Wayne",
                    Age = 20
                },
                new StudentDto
                {
                    Id = 3,
                    FullName = "John Doe",
                    Age = 40
                },
                new StudentDto
                {
                    Id = 4,
                    FullName = "Martin Panovski",
                    Age = 31
                },
            };
        }
        [HttpGet]
        public IActionResult Index()
        {
            
            return View(_students);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CreateStudentVM model)
        {
            StudentDto student = new StudentDto
            {
                Id = _students.Count +1,
                FullName = $"{model.FirstName} {model.LastName}",
                Age = DateTime.Now.Year - model.DateOfBirth.Year
            };
            _students.Add(student);

            return RedirectToAction("Index");

        }
    }
}
