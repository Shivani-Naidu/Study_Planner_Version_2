using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using ST10084788_PROG6212_POE.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ST10084788_PROG6212_POE.Pages
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public string DelegateUser;
        public string message1;
        public string tempModuleCode;
        public string DayName;

        public delegate void DisplayMessage(string a);

        private readonly TimeManagementContext context;

        //public IndexModel(TimeManagementContext context)
        //{
        //    this.context = context;
        //}

        public IndexModel(ILogger<IndexModel> logger, TimeManagementContext context)
        {
            _logger = logger;
            this.context = context;
        }

        // delegate method
        public void DelegateMethod(string message)
        {
            DelegateUser = "Hi! " + message;
        }

        public void OnGet()
        {
            DisplayMessage del = new DisplayMessage(DelegateMethod);
            // calls delegate method to generate message
            del(User.Identity.Name);
            DayName = DateTime.Today.DayOfWeek.ToString();
            //user = User.Identity.Name + "!";

            // search for days in nofication db
            // checks if the user has enetered this module before
            var DaySearch = from rec in context.Notification
                               where rec.Username == User.Identity.Name && rec.DayOfTheWeek == DayName
                               select rec;

            var DayList = DaySearch.ToList();

            if (DaySearch == null || (!DayList.Any())) // Checks if the user has entered any previous modules data
            {

                message1 = "You Have Not Selected A Module That Is To Be Studied On A " + DateTime.Today.DayOfWeek.ToString() + ".";


            }

            else
            {
                
                var stud = context.Notification.Where(g => g.Username == User.Identity.Name || g.DayOfTheWeek == DayName).ToList();

                var getModule = from rec in stud
                                where rec.Username == User.Identity.Name && rec.DayOfTheWeek == DayName
                                select rec.NotifyModuleCode;

                if (getModule != null) // if it finds the semester, it will retrieve the number of weeks in that semester
                {
                    tempModuleCode = getModule.First();


                }

                message1 = "Reminder >> You Need To Study For The " + tempModuleCode +  " Module On A " + DateTime.Today.DayOfWeek.ToString() + ".";


            }






        }
    }
}
