using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ST10084788_PROG6212_POE.Migrations.TimeManagement;
using ST10084788_PROG6212_POE.Model;

namespace ST10084788_PROG6212_POE.Pages.Semesters
{
    public class CreateModel : PageModel
    {
        // database context for the tables
        private readonly TimeManagementContext context;
       
        public CreateModel(TimeManagementContext context)
        {
            // sets the database context
            this.context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

     
        [BindProperty]
        public Semester Semester { get; set; } // used to populate the select list in the html for the semester name

        
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                // if the Model is not able to be retrieved, it will return the page
                return Page();
            }

            // check is the user has previously entered data for that semester
            var moduleSearch = from rec in context.Semester
                               where rec.Username == User.Identity.Name && rec.SemesterName == Semester.SemesterName
                               select rec;

            var modulesList = moduleSearch.ToList(); // convert the results to a list


            if (moduleSearch == null || (!modulesList.Any())) 
            {
                // if list is empty, this would mean that the user has not entered this semester data before

                // the prorgam will then save the semester data

                // get the username
                Semester.Username = User.Identity.Name;

                // add record to database
                context.Semester.Add(Semester);

                // save changes
                await context.SaveChangesAsync();

                // direct the user back to the semester page
                return RedirectToPage("./Index");

            }

            else
            {
                // if the list is not empty, it would mean that the user has already entered this semester infor
                // therefore, the prorgam will direct the user to teh edit page
                return RedirectToPage("./SemesterError");

            }
                //return RedirectToPage("./Index");

            }
    }
}
