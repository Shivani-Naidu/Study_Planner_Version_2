using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ST10084788_PROG6212_POE.Model;

namespace ST10084788_PROG6212_POE.Pages.Notifications
{
    public class DeleteModel : PageModel
    {
        private readonly TimeManagementContext _context;

        public DeleteModel(TimeManagementContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Notification Notification { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Notification = await _context.Notification.FirstOrDefaultAsync(m => m.NotificationID == id);

            if (Notification == null)
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

            Notification = await _context.Notification.FindAsync(id);

            if (Notification != null)
            {
                _context.Notification.Remove(Notification);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
