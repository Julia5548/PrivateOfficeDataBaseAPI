using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace PrivateOfficeDataBaseAPI.Models
{
    public class Classes
    {
        public int IdClasses { get; set; }
        public string NameClasses { get; set; }
        public DateAndTime StartTime { get; set; }
        public DateAndTime EndTime { get; set; }
        public int CountTime { get; set; }
        [ForeignKey("Course")]
        public int IdCourse { get; set; }
       // public virtual Course Course { get; set; }
    }
}
