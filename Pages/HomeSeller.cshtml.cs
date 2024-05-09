using Licenta2.Models;
using Licenta2.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.CodeAnalysis.CSharp;

namespace Licenta2.Pages
{
    public class HomeSellerModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public Week ModelWeek { get; set; }
		public HomeSellerModel(ApplicationDbContext context)
		{
           
			_context = context;
	
		}
        public IList<AppointmentServices> Services { get; set; }

        
		public void OnGet()
        {
         
            if(_context.AppointmentsServices!= null)
            {
				
				Services = _context.AppointmentsServices.ToList();

            }
        }
    }
}
