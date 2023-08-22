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
    public class DetailsModel : PageModel
    {
        private readonly TimeManagementContext _context;

        public DetailsModel(TimeManagementContext context)
        {
            // sets database context
            _context = context;
        }

        public Notification Notification { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {

            if (id == null)
            {
                // the notification id could not be found
                return NotFound();
            }

            Notification = await _context.Notification.FirstOrDefaultAsync(m => m.NotificationID == id);

            if (Notification == null)
            {
                
                return NotFound();
            }
            return Page();
        }
    }
}
