using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ST10084788_PROG6212_POE.Model;
using System.Threading.Tasks;

namespace ST10084788_PROG6212_POE.Pages
{
    public class LoginModel : PageModel
    {

        private readonly SignInManager<IdentityUser> signInManager;
        
        
        [BindProperty]
        public Login LModel { get; set; } 
        
        
        public void OnGet()
        {
        }

        public LoginModel(SignInManager<IdentityUser> signInManager)
        {
            this.signInManager = signInManager;
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            if (ModelState.IsValid)
            {
                var identityResult = await signInManager.PasswordSignInAsync(LModel.Username, LModel.Password, false, false);
                if (identityResult.Succeeded)
                {
                    if (returnUrl == null || returnUrl == "/")
                    {
                        return RedirectToPage("Index");
                    }
                    else
                    {
                        return RedirectToPage(returnUrl);
                    }
                }
                ModelState.AddModelError("", "Username Or Password Is Incorrect");
            }
            return Page();
        }
    }
}
