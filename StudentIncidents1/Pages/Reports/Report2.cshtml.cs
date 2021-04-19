using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StudentIncidents1.Data;
using StudentIncidents1.Models;

namespace StudentIncidents1.Pages.StudentIncidents
{
    public class Report2IndexModel : PageModel
    {
        private readonly StudentIncidents1.Data.StudentIncidents1Context _context;

        public Report2IndexModel(StudentIncidents1.Data.StudentIncidents1Context context)
        {
            _context = context;
        }


        public IList<StudentIncident> StudentIncident { get; set; }

        public async Task OnGetAsync()
        {
            /*
            StudentIncident = await _context.StudentIncident
                .Include(s => s.Incident)
                .Include(s => s.Student)
                .ToListAsync();
            */

            StudentIncident = await _context.StudentIncident
                .Include(i => i.Incident)
                .Include(s => s.Student)
                .ToListAsync();

            /*
            StudentIncidentResults = (IList<StudentIncidentList>)StudentIncident
                .FromSqlRaw("Select StudentFirstName, count(*) from StudentIncident")
                .GroupBy(o => new
                {
                    o.Student.StudentID,
                    o.Incident.IncidentName,
                })
                .Select(g => new { StudentTotal = g.Count() })
                .ToList();
            */

        }
    }
}
