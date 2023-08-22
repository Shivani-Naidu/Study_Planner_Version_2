using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SemesterClassLibrary;
using ST10084788_PROG6212_POE.Model;
using Module = ST10084788_PROG6212_POE.Model.Module;

namespace ST10084788_PROG6212_POE.Pages.Modules
{
    public class DetailsModel : PageModel
    {
        // object Calculate class -- whic is found in the DLL
        Calculate calc = new Calculate();

        // variable which is used hold the semester start date
        public DateTime semesterStartDate;

        // variable to hold the amount of hours studied this week
        public int hoursStudiedThisWeek;

        // variable that calulates the remaining number of study hours for the current week
        public int remainingHours;

        // Variable that calculates the current week in the semester
        public int currentWeekInSemester;

        // variable that holds the value for the total hours needed to study per week
        public int requiredHours;

        // holds message that will notify the user if they have completed the required amount of self-study hours
        public string message1 = ""; 

        // displays the title for the self-study statistics
        public string displayTitle = "\n****Study Statistics For The Current Week****";
       
        // varibale for the database context
        private readonly TimeManagementContext context;

        public DetailsModel(TimeManagementContext context)
        {
            // sets the database context for the tables
            this.context = context;
        }

        // Gets the information from Module class in the Model folder
        public Module Module { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {

            if (id == null)
            {
                // if the ModuleID cannot be found
                return NotFound();
            }

            Module = await context.Module.FirstOrDefaultAsync(m => m.ModuleID == id);

            if (Module == null)
            {
                // the class cannot be found
                return NotFound();
            }


            // get the details for the semester that the user has selected and convert the results to a list
            var stud = context.Semester.Where(g => g.Username == User.Identity.Name || g.SemesterName == Module.SemesterName).ToList();

            // get the sart date of the selected semester
            var semDate = from rec in stud
                          select rec.SemesterDate;

            //if (semDate != null) // if the program was able to find the semester date
            //{

                // get the start date of the semester
                semesterStartDate = semDate.First();

            //}

            // get the required amount of self-study hours (calculated by the program)
            requiredHours = Module.NeededHoursToStudy;

            // calculate the current week in the semester by using a method in the dll
            currentWeekInSemester = calc.currentWeek(semesterStartDate);


            // get the hours studied for this week
            // checks if the user has previously entered a self-study session for the module that matches to the current week 
            var calculateHours = from rec in context.StudySession
                                 where rec.ModuleCode == Module.ModuleCode && rec.Username == User.Identity.Name && rec.StudyWeek == currentWeekInSemester
                                 select rec.HoursStudied;

            var SumList = calculateHours.ToList(); // converts results into a list

            // gets the total hours studied for the current week
            hoursStudiedThisWeek = (from x in SumList select x).Sum();

            // calculates the remaining hours
            remainingHours = requiredHours - hoursStudiedThisWeek;

            // if the remaining hours < 0, then the user has exceeded the amount of required self-study hours
            if (remainingHours < 0)
            {
                remainingHours = 0;
                
                // display message to notify user that they have completed the required self-study hours
                message1 += "Nice Work, " + User.Identity.Name + "! ~ You Have Completed The Required Amount Of Self-Study Hours For The Week.";

            }
            return Page();

        }
    }
}
