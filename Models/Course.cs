using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrivateOfficeDataBaseAPI.Models
{
    public class Course
    {
        [Key] 
        public int IdCourse { get; set; }
        public string NameCourse { get; set; }

        //public List<Classes> Classes { get; set; }


    }
}
