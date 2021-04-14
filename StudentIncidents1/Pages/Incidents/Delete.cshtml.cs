using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StudentIncidents.Models;
using StudentIncidents1.Data;

namespace StudentIncidents1.Pages.Incidents
{
    public class DeleteModel : PageModel
    {
        private readonly StudentIncidents1.Data.StudentIncidents1Context _context;

        public DeleteModel(StudentIncidents1.Data.StudentIncidents1Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Incident Incident { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Incident = await _context.Incident.FirstOrDefaultAsync(m => m.IncidentID == id);

            if (Incident == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Incident = await _context.Incident.FindAsync(id);

            if (Incident != null)
            {
                _context.Incident.Remove(Incident);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
