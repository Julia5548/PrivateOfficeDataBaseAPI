using System.ComponentModel.DataAnnotations;

namespace PrivateOfficeDataBaseAPI.Models
{
    public class Teacher
    {
        [Key]
        public int IdTeacher { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }

    }
}
