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
    public class DetailsModel : PageModel
    {
        private readonly StudentIncidents1.Data.StudentIncidents1Context _context;

        public DetailsModel(StudentIncidents1.Data.StudentIncidents1Context context)
        {
            _context = context;
        }

        public StudentIncident StudentIncident { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            StudentIncident = await _context.StudentIncident
                .Include(s => s.Incident)
                .Include(s => s.Student).FirstOrDefaultAsync(m => m.StudentId == id);

            if (StudentIncident == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
