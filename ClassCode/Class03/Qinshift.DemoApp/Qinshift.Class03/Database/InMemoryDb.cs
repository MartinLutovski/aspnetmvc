using Qinshift.Class03.Models.Entities;

namespace Qinshift.Class03.Database
{
    public static class InMemoryDb
    {
        static InMemoryDb()
        {
            LoadCourses();
            LoadStudents();
        }
        public static List<Student> Students { get; set; }
        public static List<Course> Courses { get; set; }

        private static void LoadStudents()
        {
            Students = new List<Student>()
                {
                    new Student()
                    {
                        Id = 1,
                        FirstName = "John",
                        LastName = "Doe",
                        DateOfBirth =  DateTime.Now.AddYears(-27),
                        ActiveCourse = Courses[1]
                    },
                    new Student()
                    {
                        Id = 2,
                        FirstName = "Jane",
                        LastName = "Smith",
                        DateOfBirth = DateTime.Now.AddYears(-23),
                        ActiveCourse = Courses[2]
                    }
                };
        }
        private static void LoadCourses()
        {
            Courses = new List<Course>()
                {
                    new Course()
                    {
                        Id = 1,
                        Name = "Mathematics",
                        NumberOfClasses = 30
                    },
                    new Course()
                    {
                        Id = 2,
                        Name = "Physics",
                        NumberOfClasses = 25
                    },
                    new Course()
                    {
                        Id = 3,
                        Name = "Chemistry",
                        NumberOfClasses = 20
                    }
                };
        }
    }
}

