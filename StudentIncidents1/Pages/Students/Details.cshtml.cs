using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StudentIncidents.Models;
using StudentIncidents1.Data;

namespace StudentIncidents1.Pages.Students
{
    public class DetailsModel : PageModel
    {
        private readonly StudentIncidents1.Data.StudentIncidents1Context _context;

        public DetailsModel(StudentIncidents1.Data.StudentIncidents1Context context)
        {
            _context = context;
        }

        public Student Student { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Student = await _context.Student.FirstOrDefaultAsync(m => m.StudentID == id);

            if (Student == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
