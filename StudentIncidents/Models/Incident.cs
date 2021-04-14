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
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Incident Date")]
        public DateTime IncidentDate { get; set; }

        [Required]
        public string IncidentName { get; set; }


    }
}
