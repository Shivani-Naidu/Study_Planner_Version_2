using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ST10084788_PROG6212_POE.Model;

namespace ST10084788_PROG6212_POE.Pages.Notifications
{
    public class CreateModel : PageModel
    {
        // database context
        private readonly TimeManagementContext context;
        
        // variable to hold the day of the week
        public string DayName;

        public CreateModel(TimeManagementContext context)
        {
            // sets the database context
            this.context = context;
        }

        // select list that used to get the options 
        public List<SelectListItem> Options { get; set; }
        public IActionResult OnGet()
        {
            // populate the select list that is found in the html with the module codes of the current logged in user
            var username = User.Identity.Name;
            Options = new SelectList(context.Module.Where(g => g.Username == username), "ModuleCode", "ModuleCode").ToList();

            return Page();
        }
        

        [BindProperty]
        public Notification Notification { get; set; } // Gets the information from Notification class in the Model folder 

      
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // get current day of the week from user's system date
            DayName = DateTime.Today.DayOfWeek.ToString();

            // make sure the user has not selected the day for a module already
            var daySearch = from rec in context.Notification
                            where rec.Username == User.Identity.Name && rec.DayOfTheWeek == Notification.DayOfTheWeek
                            select rec;

            var daysList = daySearch.ToList(); // convert results to a list

            if (daySearch == null || (!daysList.Any())) // Checks if the list is empty
                                                        // if the list is empty, this would mean that the user has notr selected this day
            {
                // get the username of the current logged in user
                Notification.Username = User.Identity.Name;

                // save this record to the database
                context.Notification.Add(Notification);

                // save changes
                await context.SaveChangesAsync();
               
                // direct user to index page
                return RedirectToPage("./Index");

            }

            else
            {
                // if the list is not empty, this would mean that the user has previously used this day before and
                // it has been allocated for a module already, therefore the program will display an error message
                return RedirectToPage("./NotificationError");

            }

            //return RedirectToPage("./Index");
        }
    }
}
