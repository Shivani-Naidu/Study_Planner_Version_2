using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ST10084788_PROG6212_POE.Model;

namespace ST10084788_PROG6212_POE.Pages.Notifications
{
    public class EditModel : PageModel
    {
        private readonly TimeManagementContext _context;
        public string DayName;

        public EditModel(TimeManagementContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Notification Notification { get; set; }
        public List<SelectListItem> Options { get; set; }

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

            // populates the select list with module codes of the current logged in user
            var username = User.Identity.Name;
            Options = new SelectList(_context.Module.Where(g => g.Username == username), "ModuleCode", "ModuleCode").ToList();
            return Page();
        }

       
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Notification).State = EntityState.Modified;


            try
            {

                // ensure that the user has not selected this day for a module already
                var daySearch = from rec in _context.Notification
                                where rec.Username == User.Identity.Name && rec.DayOfTheWeek == Notification.DayOfTheWeek
                                select rec;

                var daysList = daySearch.ToList(); // convert results to list

                if (daySearch == null || (!daysList.Any())) // Checks if the list is empty
                                                            // if the list is empty, this would mean that the user has notr selected this day
                {
                    // get username of current logged in user
                    Notification.Username = User.Identity.Name;

                    // save changes
                    await _context.SaveChangesAsync();
                    
                    return RedirectToPage("./Index");

                }

                else
                {
                    return RedirectToPage("./NotificationError");

                }

                   
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NotificationExists(Notification.NotificationID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            //return RedirectToPage("./Index");
        }

        private bool NotificationExists(int id)
        {
            return _context.Notification.Any(e => e.NotificationID == id);
        }
    }
}
