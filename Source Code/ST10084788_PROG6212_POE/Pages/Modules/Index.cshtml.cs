using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ST10084788_PROG6212_POE.Model;

namespace ST10084788_PROG6212_POE.Pages.Modules
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly TimeManagementContext context;

        public IndexModel(TimeManagementContext context)
        {
            this.context = context;
        }

        public IList<Module> Module { get;set; }

        public async Task OnGetAsync()
        {
            Module = (from m in context.Module
                        where m.Username == User.Identity.Name
                        select m).ToList();
        }
    }
}
