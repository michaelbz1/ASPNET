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
    public class IndexModel : PageModel
    {
        private readonly StudentIncidents1.Data.StudentIncidents1Context _context;

        public IndexModel(StudentIncidents1.Data.StudentIncidents1Context context)
        {
            _context = context;
        }

        public IList<Student> Student { get;set; }

        public async Task OnGetAsync()
        {
            Student = await _context.Student.ToListAsync();
        }
    }
}
