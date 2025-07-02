using Class09.EntityFramework.Database;
using Microsoft.AspNetCore.Mvc;

namespace Class09.EntityFramework.Controllers
{
    public class StudentController : Controller
    {

        private readonly AcademyDbContext _context;

        public StudentController(AcademyDbContext context)
        {
            _context = context;
        } // bad practice to use DbContext directly in the controller, consider using a service layer.
        // This is just for demonstration purposes in the interest of time.





        public IActionResult Index()
        {
            var students = _context.Students.ToList();
            return View(students);
        }
    }
}
