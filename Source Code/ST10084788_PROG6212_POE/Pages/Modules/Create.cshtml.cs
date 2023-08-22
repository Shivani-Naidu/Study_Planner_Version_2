using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ST10084788_PROG6212_POE.Model;
using SemesterClassLibrary;

namespace ST10084788_PROG6212_POE.Pages.Modules
{
    public class CreateModel : PageModel
    {
        Calculate calcs = new Calculate(); // object of calculate class which is present in the dll
        private readonly TimeManagementContext context; // context of the database tables
        int semesterWeeks; // holds the number of weeks in the semester

        public CreateModel(TimeManagementContext context)
        {
            // sets the database context
            this.context = context;
        }
        
        public List<SelectListItem> Options { get; set; } // used to populate the select list in the html for the semester name

        public IActionResult OnGet()
        {
            var username = User.Identity.Name; // gets the username of the current logged in user
            
            // populates the select list with the semester names for that user
            Options = new SelectList(context.Semester.Where(g => g.Username == username), "SemesterName", "SemesterName").ToList();

            return Page();
        }

        
        [BindProperty]
        public Module Module { get; set; } // Gets the information from Module class in the Model folder
       
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                // if the Module class is not found, then the program will display the page
                return Page();
            }

            // checks if the user has enetered this module before
            var moduleSearch = from rec in context.Module
                               where rec.Username == User.Identity.Name && rec.ModuleCode== Module.ModuleCode
                               select rec;

             var modulesList = moduleSearch.ToList(); // converts the results to a list

            if (moduleSearch == null || (!modulesList.Any())) // if the list is empty, it would mean that the user has not entered
                                                             // therefore, the program will then allow the user to this module info
            {
                // set a value for the username -- current user
                Module.Username = User.Identity.Name;
                
                // get the semester that the user has chosen and then convert the results to a list
                var stud = context.Semester.Where(g => g.Username ==  User.Identity.Name || g.SemesterName == Module.SemesterName).ToList();
                
                var semWeeks = from rec in stud
                               select rec.SemesterWeeks; // from the list, get the number of weeks

                if (semWeeks != null) // if it finds the semester weeks, it will save the value into the temp variable
                {
                        
                    semesterWeeks = semWeeks.First();
                        
                }

                // call the method from the dll to calculate the amount of hours that the user needs to study for per week
                Module.NeededHoursToStudy = calcs.CalcHoursPerWeek(Module.ModuleCredits, semesterWeeks , Module.ClassHoursPerWeek);
                   
                // get the username of the current logged in user
                Module.Username = User.Identity.Name;
                    
                // add the module information to the database
                context.Module.Add(Module);
                
                // save changes
                await context.SaveChangesAsync();

                // redirect the user to the module index page one the record has been added
                return RedirectToPage("./Index");

                }

            

            else // the user has already saved this module code before
            {
                return RedirectToPage("./ModuleError"); // directs the user to the error page

            }

           // return RedirectToPage("./Index");
        }
    }
}
