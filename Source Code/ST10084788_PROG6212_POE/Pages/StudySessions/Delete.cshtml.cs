using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ST10084788_PROG6212_POE.Model;

namespace ST10084788_PROG6212_POE.Pages.StudySessions
{
    public class DeleteModel : PageModel
    {
        private readonly TimeManagementContext _context;

        public DeleteModel(TimeManagementContext context)
        {
            _context = context;
        }

        [BindProperty]
        public StudySession StudySession { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            StudySession = await _context.StudySession.FirstOrDefaultAsync(m => m.StudyId == id);

            if (StudySession == null)
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

            StudySession = await _context.StudySession.FindAsync(id);

            if (StudySession != null)
            {
                _context.StudySession.Remove(StudySession);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
