using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudentIncidents.Models;

namespace StudentIncidents1.Data
{
    public class StudentIncidents1Context : DbContext
    {
        public StudentIncidents1Context (DbContextOptions<StudentIncidents1Context> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.StudentIncident>().HasKey(sc => new { sc.StudentId, sc.IncidentId });
        }
        public DbSet<Student> Student { get; set; }

        public DbSet<Incident> Incident { get; set; }
        public DbSet<Models.StudentIncident> StudentIncident { get; set; }


    }
}
