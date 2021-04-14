using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StudentIncidents1.Data;
using StudentIncidents1.Models;

namespace StudentIncidents1.Pages.StudentIncidents
{
    public class EditModel : PageModel
    {
        private readonly StudentIncidents1.Data.StudentIncidents1Context _context;

        public EditModel(StudentIncidents1.Data.StudentIncidents1Context context)
        {
            _context = context;
        }

        [BindProperty]
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
           ViewData["IncidentId"] = new SelectList(_context.Incident, "IncidentID", "IncidentName");
           ViewData["StudentId"] = new SelectList(_context.Student, "StudentID", "StudentFirstName");
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

            _context.Attach(StudentIncident).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StudentIncidentExists(StudentIncident.StudentId))
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

        private bool StudentIncidentExists(int id)
        {
            return _context.StudentIncident.Any(e => e.StudentId == id);
        }
    }
}
