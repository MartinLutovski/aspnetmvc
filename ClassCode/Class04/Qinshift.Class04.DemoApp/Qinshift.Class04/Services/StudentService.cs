using Qinshift.Class04.Database;
using Qinshift.Class04.Models.DtoModel;
using Qinshift.Class04.Models.Entities;
using Qinshift.Class04.Models.ViewModels;

namespace Qinshift.Class04.Services
{
    public class StudentService
    {
        public List<StudentWithCourseDto> GetAllStudents()
        {
            List<StudentWithCourseDto> students = InMemoryDb.Students.Select(x => new StudentWithCourseDto(x.Id, x.FirstName, x.LastName, x.DateOfBirth, x.ActiveCourse.Name)).ToList();

            return students;
        }

            //List<StudentWithCourseDto> students = InMemoryDb.Students.Select(x => new StudentWithCourseDto(x.Id, x.FirstName, x.LastName, x.DateOfBirth, x.ActiveCourse.Name)).ToList();
            //List<StudentWithCourseDto> students = InMemoryDb.Students.Select(x => new StudentWithCourseDto
            //{
            //    Id = x.Id,
            //    FirstName = x.FirstName,
            //    LastName = x.LastName,
            //    DateOfBirth = x.DateOfBirth,
            //    CourseName = x.ActiveCourse.Name
            //}).ToList(); // Example of using a constructor in the DTO

            public StudentWithCourseDto GetStudentById(int id)
        {
            Student student = InMemoryDb.Students.FirstOrDefault(x => x.Id == id);
            if (student == null)
            {
                return null;
            }
            return new StudentWithCourseDto(student.Id, student.FirstName, student.LastName, student.DateOfBirth, student.ActiveCourse.Name);
        }

        public void CreateStudent(CreateStudentVM viewModel)
        {
            Student entity = new Student
            {
                Id = InMemoryDb.Students.Count + 1, // Simple ID generation
                FirstName = viewModel.FirstName,
                LastName = viewModel.LastName,
                DateOfBirth = viewModel.DateOfBirth,
                ActiveCourse = InMemoryDb.Courses[2]
            };
            InMemoryDb.Students.Add(entity);
        }
    }
}

