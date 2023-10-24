using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace DemoMVC.Models
{
    public class StudentModel
    {
        public int StudentId { get; set; }
        [Display(Name = "Name")]
        public string StudentName { get; set; }
        public int Age { get; set; }
        public bool isNewlyEnrolled { get; set; }
        public string Password { get; set; }

        public string Description { get; set; }

        public bool isActive { get; set; }
        public string Gender { get; set; }

        public Gender StudentGender { get; set; }

    }

    public enum Gender
    {
        Male,
        Female
    }

  

}
