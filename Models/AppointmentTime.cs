using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Licenta2.Models
{
    public class AppointmentTime

    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DisplayName("Appointment Date")]
        [DataType(DataType.Date)]
        public DateTime AppointmentDate { get; set; }

        [Required]
        public TimeSpan Time { get; set; }
    }
}
