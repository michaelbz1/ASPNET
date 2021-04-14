using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StudentIncidents.Models;
using StudentIncidents1.Data;

namespace StudentIncidents1.Pages.Incidents
{
    public class EditModel : PageModel
    {
        private readonly StudentIncidents1.Data.StudentIncidents1Context _context;

        public EditModel(StudentIncidents1.Data.StudentIncidents1Context context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Incident).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!IncidentExists(Incident.IncidentID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool IncidentExists(int id)
        {
            return _context.Incident.Any(e => e.IncidentID == id);
        }
    }
}
