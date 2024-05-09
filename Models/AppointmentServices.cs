using Microsoft.CodeAnalysis.CSharp;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Licenta2.Models
{
    public class AppointmentServices
    {
        [Required]
        public int UserID { get; set; } 

        [Key]
        public int AppointmentServicesId { get; set; }

        [ForeignKey("Id")]
        public virtual required ApplicationUser User { get; set; }

        [Required, MaxLength(50)]
        public string ServiceName { get; set; }

        //Descriere

        [Required, MaxLength(1000)]
        public string Description { get; set; }

        //Pret

        [Required]
        public int Price { get; set; }

        //Imagine

		public string EmpImageData {  get; set; }

        [NotMapped]
        public IFormFile ImageFile { get; set; }

        //Reviews

        public virtual ICollection<Reviews> Reviews { get; set; }

        //Calendar

        public virtual ICollection<Week> Weeks { get; set; } = new List<Week>();

        public void SetWeek(Week WeekSet)
        {
			if (Weeks == null) throw new InvalidOperationException("Weeks collection is not initialized.");
			foreach (var week in Weeks) 
            {
				foreach (var day in week.Days)
                {
                    foreach(var daySet in WeekSet.Days)
                    {
                        if(day.Name == daySet.Name)
                        {
                            day.StartHour = daySet.StartHour;
                            day.EndHour = daySet.EndHour;
                        }
                    }
                }
		
			}
            

        }
    }
}
