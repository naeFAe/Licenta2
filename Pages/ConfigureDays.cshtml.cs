using Licenta2.Models;
using Licenta2.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Licenta2.Pages
{
    public class ConfigureDaysModel : PageModel
    {
		private readonly ApplicationDbContext _context;
		public Week ModelWeek { get; set; }
		public ConfigureDaysModel(ApplicationDbContext context)
		{
			ModelWeek = new Week();
			ModelWeek.InitializeDays();
			_context = context;
		}

		[BindProperty(SupportsGet = true)]
		public AppointmentServices AppointmentServices { get; set; }
		public async Task<IActionResult> OnGetAsync(int id)
		{
			
			AppointmentServices = await _context.AppointmentsServices.FindAsync(id);
			AppointmentServices.SetWeek(ModelWeek);
			return Page();
		}


    }
}
