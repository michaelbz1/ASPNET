using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudentIncidents1.Models;

namespace StudentIncidents1.Data
{
    public class StudentIncidents1Context : DbContext
    {
        public StudentIncidents1Context (DbContextOptions<StudentIncidents1Context> options)
            : base(options)
        {
        }

        public DbSet<StudentIncidents1.Models.StudentIncident> StudentIncident { get; set; }

        public DbSet<StudentIncidents.Models.Incident> Incident { get; set; }

        public DbSet<StudentIncidents.Models.Student> Student { get; set; }
    }
}
