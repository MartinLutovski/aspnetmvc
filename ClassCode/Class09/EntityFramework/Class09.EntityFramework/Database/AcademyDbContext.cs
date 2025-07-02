using Class09.EntityFramework.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Class09.EntityFramework.Database
{
    public class AcademyDbContext : DbContext
    {
        // 1. First add the constructor with the needed DbContextOptions passed to its parent constructor.
        public AcademyDbContext(DbContextOptions options) : base(options)
        {

        }
        // 2. Configure which models will be translated as tables in the database.

        public  DbSet<Student> Students { get; set; }

        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            List<Course> courses = new()
            {
                new Course
                {
                    Id = 1,
                    Name = "Mathematics",
                    NumberOfClasses = 3
                },
                new Course
                {
                    Id = 2,
                    Name = "Physics",
                    NumberOfClasses = 4
                }

                
            };

            List<Student> students = new()
            {
                new Student
                {
                    Id = 1,
                    FirstName = "John",
                    LastName = "Doe",
                    DateOfBirth = new DateTime(2000, 1, 1),
                    ActiveCourseId = 1
                },

                new Student
                {
                    Id = 2,
                    FirstName = "Jane",
                    LastName = "Smith",
                    DateOfBirth = new DateTime(2001, 2, 2),
                    ActiveCourseId = 2
                },

                new Student
                {
                    Id = 3,
                    FirstName = "Alice",
                    LastName = "Johnson",
                    DateOfBirth = new DateTime(2002, 3, 3),
                    ActiveCourseId = 1
                }
            };

            modelBuilder.Entity<Course>().HasData(courses);
            modelBuilder.Entity<Student>().HasData(students);
        }

    }
}
