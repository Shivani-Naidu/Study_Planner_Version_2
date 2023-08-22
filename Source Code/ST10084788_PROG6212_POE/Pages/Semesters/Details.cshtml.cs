using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ST10084788_PROG6212_POE.Model;

namespace ST10084788_PROG6212_POE.Pages.Semesters
{
    public class DetailsModel : PageModel
    {
        private readonly TimeManagementContext _context;

        public DetailsModel(TimeManagementContext context)
        {
            _context = context;
        }

        public Semester Semester { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Semester = await _context.Semester.FirstOrDefaultAsync(m => m.SemesterID == id);

            if (Semester == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
