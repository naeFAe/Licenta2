using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace Licenta2.Models
{
	public class Day
	{
		[Key]
		public int Id { get; set; }

		[Required]
		public string Name { get; set; }

		[Required]
		public string StartHour { get; set; }

		[Required]
		public string EndHour { get; set; }

		[Required]
		public int WeekId { get; set; }

		[ForeignKey("WeekId")]
		public virtual Week Week { get; set; }

		//Dictionar cu ore
		public Dictionary<DateTime, bool> GenerateMarkedTimeIntervals()
		{
			var timeIntervals = new Dictionary<DateTime, bool>();
			DateTime start = DateTime.ParseExact(StartHour, "HH:mm", CultureInfo.InvariantCulture);
			DateTime end = DateTime.ParseExact(EndHour, "HH:mm", CultureInfo.InvariantCulture);

			while (start < end)
			{
				timeIntervals.Add(start, false);  // Presupunem inițial că toate intervalele sunt libere (false)
				start = start.AddMinutes(30);
			}

			return timeIntervals;
		}

		// Funcția pentru a marca intervale de timp ca rezervate
		public void MarkTimeIntervals(Dictionary<DateTime, bool> intervals, DateTime timeToMark, bool status)
		{
			if (intervals.ContainsKey(timeToMark))
			{
				intervals[timeToMark] = status;
			}
		}

		// Liste de SelectListItem pentru a fi folosite în dropdown-uri
		[NotMapped]
		public List<SelectListItem> HourOptions { get; private set; }

		public Day()
		{
			HourOptions = GenerateHourOptions();
		}

		private List<SelectListItem> GenerateHourOptions()
		{
			List<SelectListItem> options = new List<SelectListItem>();
			for (int hour = 8; hour <= 22; hour++)
			{
				for (int minute = 0; minute < 60; minute += 30) // Ora și minute
				{
					string time = $"{hour:D2}:{minute:D2}";
					options.Add(new SelectListItem { Value = time, Text = time });
				}
			}
			return options;
		}
	}
}
