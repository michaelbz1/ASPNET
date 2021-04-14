using StudentIncidents1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentIncidents.Models
{
    public class Student
    {
        [Key]
        public int StudentID { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string StudentFirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string StudentLastName { get; set; }
        public string StudentPhone { get; set; }
        public string StudentEmail { get; set; }

        public IList<StudentIncident> StudentIncidents { get; set; }


    }
}
