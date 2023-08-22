using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ST10084788_PROG6212_POE.Model;

namespace ST10084788_PROG6212_POE.Pages.StudySessions
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly TimeManagementContext context;

        public IndexModel(TimeManagementContext context)
        {
            this.context = context;
        }

        public IList<StudySession> StudySession { get;set; }

        public async Task OnGetAsync()
        {
            StudySession = (from ss in context.StudySession
                                       where ss.Username == User.Identity.Name
                                       select ss).ToList();
        }
    }
}
