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
    public class ReportIndexModel : PageModel
    {
        private readonly StudentIncidents1.Data.StudentIncidents1Context _context;

        public ReportIndexModel(StudentIncidents1.Data.StudentIncidents1Context context)
        {
            _context = context;
        }

        public IList<StudentIncident> StudentIncident { get; set; }
        public int StudentTotal;

        public async Task OnGetAsync()
        {
            StudentIncident = await _context.StudentIncident
                .Include(s => s.Incident)
                .Include(s => s.Student)
                .OrderBy(i => i.Student.StudentLastName)
                .OrderBy(p => p.Student.StudentFirstName)
                .OrderByDescending(q => q.IncidentDate)
                .OrderBy(r => r.Incident.IncidentName)
                .ToListAsync();

        }
    }
}
