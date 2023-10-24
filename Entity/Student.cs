using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Entity
{
    public class Student
    {
        public int StudentId { get; set; }
        [Display(Name = "Name")]
        public string StudentName { get; set; }
        public int Age { get; set; }


    }
}