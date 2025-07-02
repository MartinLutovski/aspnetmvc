using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Class09.EntityFramework.Models.Entities
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        // [ForeignKey[Fk_ActiveCourseId]
        public int ActiveCourseId { get; set; } 

        public virtual Course ActiveCourse { get; set; }


    }
}
