using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudentIncidents.Models;

namespace StudentIncidents.Data
{
    public class StudentIncidentsContext : DbContext
    {
        public StudentIncidentsContext (DbContextOptions<StudentIncidentsContext> options)
            : base(options)
        {
        }

        public DbSet<StudentIncidents.Models.Student> Student { get; set; }
    }
}
