using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ST10084788_PROG6212_POE.Model;
using SemesterClassLibrary;

namespace ST10084788_PROG6212_POE.Pages.StudySessions
{
    public class CreateModel : PageModel
    {
        // database context for tables
        private readonly TimeManagementContext context;
        
        public List<SelectListItem> Options { get; set; } // used to populate the select list in the html for the module code

        Calculate calcs = new Calculate();  // object of calculate class which is present in the dll

        public string semName; // variable to hold the semester name
        public DateTime semSDate; // variable to hold the semester start date

        public CreateModel(TimeManagementContext context)
        {
            // sets the database context
            this.context = context;
        }

        public IActionResult OnGet()
        {
            // gets the username of the current logged in user
            var username = User.Identity.Name;

            // populates the select list with the module codes for that user
            Options = new SelectList(context.Module.Where(g => g.Username == username), "ModuleCode", "ModuleCode").ToList();

            return Page();
        }

        [BindProperty]
        public StudySession StudySession { get; set; }  // Gets the information from semester class in the Model folder


        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            //  get the semester name for the selected module and convert the results to a list
            var stud = context.Module.Where(g => g.Username == User.Identity.Name || g.ModuleCode == StudySession.ModuleCode).ToList();


            //  get the semester name from the list
            var semesterName = from rec in stud
                               where rec.ModuleCode == StudySession.ModuleCode
                               select rec.SemesterName;

            if (semesterName != null) // it will then get the semester name from the list
            {

                semName = semesterName.Last();

            }

            // add the semester name
            StudySession.SemesterName = semName;

            // get the semester start date and convert the results to a list
            var stud2 = context.Semester.Where(g => g.Username == User.Identity.Name || g.SemesterName == StudySession.SemesterName).ToList();

            var semesterDate = from rec in stud2
                               select rec.SemesterDate;

            if (semesterDate != null) // if it finds the semester, it will retrieve the semester start date
            {

                semSDate = semesterDate.First();

            }

            // call method from the dll to calculate the study week
            StudySession.StudyWeek = calcs.workWeek(StudySession.StudyDate, semSDate);

            // get username of current user
            StudySession.Username = User.Identity.Name; 

            // add record to database
            context.StudySession.Add(StudySession);

            // save changes
            await context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
