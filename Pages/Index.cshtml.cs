using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Licenta2.Models;
using Microsoft.AspNetCore.Identity;

namespace Licenta2.Pages
{
    public class IndexModel : PageModel
    {
        private readonly SignInManager<ApplicationUser> _signInManager;

        public IndexModel(SignInManager<ApplicationUser> signInManager)
        {
            _signInManager = signInManager;
        }

        public IActionResult OnGet()
        {
            if (_signInManager.IsSignedIn(User) && User.IsInRole("admin"))
            {
                return Redirect("/admin");
            }
            else if (_signInManager.IsSignedIn(User) && User.IsInRole("client"))
            {
                return Redirect("/client");
            }
            else if (_signInManager.IsSignedIn(User) && User.IsInRole("seller"))
            {
                return Redirect("/seller");
            }
            return Page();
        }
    }
}