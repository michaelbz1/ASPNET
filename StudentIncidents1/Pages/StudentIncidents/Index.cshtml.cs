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
    public class IndexModel : PageModel
    {
        private readonly StudentIncidents1.Data.StudentIncidents1Context _context;

        public IndexModel(StudentIncidents1.Data.StudentIncidents1Context context)
        {
            _context = context;
        }

        public IList<StudentIncident> StudentIncident { get;set; }

        public async Task OnGetAsync()
        {
            StudentIncident = await _context.StudentIncident
                .Include(s => s.Incident)
                .Include(s => s.Student).ToListAsync();
        }
    }
}
