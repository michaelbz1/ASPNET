﻿using StudentIncidents.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentIncidents1.Models
{
    public class StudentIncident
    {
        [Key]
        public int ID { get; set; }

        public int StudentId { get; set; }
        public Student Student { get; set; }

        public int IncidentId { get; set; }
        public Incident Incident { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Incident Date")]
        public DateTime IncidentDate { get; set; }
    }
}
