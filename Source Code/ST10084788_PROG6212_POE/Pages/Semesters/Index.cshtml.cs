using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ST10084788_PROG6212_POE.Model;

namespace ST10084788_PROG6212_POE.Pages.Semesters
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly TimeManagementContext context;

        public IndexModel(TimeManagementContext context)
        {
            this.context = context;
        }

        public IList<Semester> Semester { get;set; }

        public async Task OnGetAsync()
        {
            Semester = (from s in context.Semester
                        where s.Username == User.Identity.Name
                        select s).ToList();
        }
    }
}
