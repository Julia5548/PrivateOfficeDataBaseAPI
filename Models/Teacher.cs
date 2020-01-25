using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PrivateOfficeDataBaseAPI.Models
{
    public class Teacher
    {
        [Key]
        public int IdTeacher { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Patronymic { get; set; }

        //public virtual List<Course> Course { get; set; }


    }
}
