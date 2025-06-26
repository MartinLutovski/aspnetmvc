using System.ComponentModel.DataAnnotations;

namespace Avenga.Class07.ModelBinding.Models.ViewModels
{
    public class CreateStudentVM
    {
        [Required]
        [Display(Name = "Firstname")]
        public string FirstName { get; set; }


        [Required]
        [Display(Name = "Lastname")]
        public string LastName { get; set; }


        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }


        [Display(Name = "Additional Info")]
        public string AdditionalInfo { get; set; }


        [Required]
        [Display(Name = "Date of birth")]
        public DateTime DateOfBirth { get; set; }
    }
}
