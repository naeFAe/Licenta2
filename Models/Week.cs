using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Licenta2.Models
{
	public class Week
	{
		[Key]
		public int Id { get; set; }

		// Proprietăți pentru fiecare zi a săptămânii
		[NotMapped]
		public virtual ICollection<Day> Days { get; set; } = new List<Day>();

		
		public int SeriviceId { get; set; }

		[ForeignKey("ServiceId")]
		public virtual AppointmentServices AppointmentServices { get; set; }
		public void InitializeDays()
		{
			Days.Add(new Day { Name = "Monday",StartHour="8:00",EndHour="22:00"});
			Days.Add(new Day { Name = "Tuesday", StartHour = "8:00", EndHour = "22:00" });
			Days.Add(new Day {Name = "Wednesday", StartHour = "8:00", EndHour = "22:00" });
			Days.Add(new Day {Name = "Thursday", StartHour = "8:00", EndHour = "22:00" });
			Days.Add(new Day {Name = "Friday", StartHour = "8:00", EndHour = "22:00" });
			Days.Add(new Day {Name = "Saturday", StartHour = "8:00", EndHour = "22:00" });
			Days.Add(new Day {Name = "Sunday", StartHour = "8:00", EndHour = "22:00" });
		}

		
	}
}
