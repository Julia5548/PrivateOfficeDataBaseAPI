using System.ComponentModel.DataAnnotations;

namespace PrivateOfficeDataBaseAPI.Models
{
    public class Course
    {
        [Key] 
        public int IdCourse { get; set; }
        public string NameCourse { get; set; }
        public int IdTeacher { get; set; }

        public virtual Teacher Teacher { get; set; }
    }
}
