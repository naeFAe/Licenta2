using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Licenta2.Pages
{
    [Authorize(Roles ="client")]
    public class ClientModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
