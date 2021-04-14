using StudentIncidents1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentIncidents.Models
{
    public class Incident
    {

        [Key]
        public int IncidentID { get; set; }

        [Required]
        public string IncidentName { get; set; }

        public IList<StudentIncident> StudentIncidents { get; set; }
    }
}
