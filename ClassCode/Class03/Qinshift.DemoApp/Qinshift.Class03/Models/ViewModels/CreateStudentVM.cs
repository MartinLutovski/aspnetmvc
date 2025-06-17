namespace Qinshift.Class03.Models.ViewModels
{
    public class CreateStudentVM
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DoB { get; set; } // Date of Birth, you can also use DateOfBirth 
        // later you can connect DoB with DateOfBirth in the Student entity
    }
}
