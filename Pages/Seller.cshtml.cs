using Licenta2.Models;
using Licenta2.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;


namespace Licenta2.Pages
{
    public class SellerModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        [BindProperty]
        public AppointmentServices Services { get; set; } 
        public Week Week1 { get; set; }
		public Week Week2 { get; set; }
		public Week Week3 { get; set; }
		public Week Week4 { get; set; }

		/*public Week ModelWeek { get; set; }*/


		/*   public Week ModelWeek { get; set; }*/
		public SellerModel(ApplicationDbContext context) 
        {

            
            /*ModelWeek = new Week();
			ModelWeek.InitializeDays();*/
           
			_context = context;
        }


        
       
        public IActionResult OnGet()
        {
          /*  ModelWeek = new Week();
            ModelWeek.InitializeDays();*/
            return Page();
        }
/*		public IActionResult OnPostSaveWeek()
		{
			// Adaugă ModelWeek la context și salvează schimbările
			_context.Weeks.Add(ModelWeek);
			_context.SaveChanges();
            
			return RedirectToPage();  // Redirecționează la aceeași pagină sau la un mesaj de succes
		}*/
		public IActionResult OnPost()
        {
          

			byte[] bytes = null;

            if(Services.ImageFile != null)
            {
                using (Stream fs = Services.ImageFile.OpenReadStream())
                {
                    using(BinaryReader br = new BinaryReader(fs))
                    {
                        bytes=br.ReadBytes((Int32)(fs.Length)); 
                    }
                }
                Services.EmpImageData=Convert.ToBase64String(bytes,0,bytes.Length);

            
            }
            
			_context.AppointmentsServices.Add(Services);
			_context.SaveChanges();
			/*foreach (Day day in ModelWeek.Days)
            {
                Console.WriteLine(day.StartHour);
            }
            ModelWeek.SeriviceId = Services.AppointmentServicesId;

            Services.Weeks.Add(ModelWeek);
            _context.AppointmentsServices.Add(Services);
			try
			{
				_context.SaveChanges();
			}
			catch (DbUpdateException ex)
			{
				var innerException = ex.InnerException?.Message ?? "No inner exception";
				Console.WriteLine($"Error: {innerException}");
				// sau loghează eroarea
				throw; // Opțional: relansează excepția dacă nu poți rezolva aici
			}
*/

			return RedirectToPage("./Seller");
        }

    }
}
