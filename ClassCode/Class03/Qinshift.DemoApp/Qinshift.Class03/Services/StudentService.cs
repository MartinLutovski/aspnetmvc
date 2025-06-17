using Qinshift.Class03.Database;
using Qinshift.Class03.Models.DTOModels;
using Qinshift.Class03.Models.Entities;

namespace Qinshift.Class03.Services
{
    public class StudentService
    {
        public object FullName { get; private set; }

        public StudentWithCourseDto GetStudentCourse(int id)
        {
            Student student = InMemoryDb.Students.SingleOrDefault(x => x.Id == id);
            if (student == null)
            {
                return null;
            }
            StudentWithCourseDto studentWithCourse = new StudentWithCourseDto
            {
                Id = student.Id,
                FullName = $"{student.FirstName} {student.LastName}",
                Age = DateTime.Now.Year - student.DateOfBirth.Year,
                NameOfCourse = student.ActiveCourse.Name
            };
            return studentWithCourse;
        }

        public List<ListAllStudentsDto> GetАllStudents()
        {
            return InMemoryDb.Students.Select(student => new ListAllStudentsDto
            {
                FullName = $"{student.FirstName} {student.LastName}"
            }).ToList();
        }
    }
}
