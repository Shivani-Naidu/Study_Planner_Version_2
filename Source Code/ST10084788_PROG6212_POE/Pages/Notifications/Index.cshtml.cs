using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ST10084788_PROG6212_POE.Model;

namespace ST10084788_PROG6212_POE.Pages.Notifications
{

    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly TimeManagementContext context;

        public IndexModel(TimeManagementContext context)
        {
            this.context = context;
        }

        public IList<Notification> Notification { get;set; }

        public async Task OnGetAsync()
        {
            // display list of reminders only for the current logged in user
            Notification = await context.Notification.Where(n => n.Username == User.Identity.Name).ToListAsync();
                                    
        }
    }
}
