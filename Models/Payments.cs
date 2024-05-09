using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Licenta2.Models
{
    public class Payments
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string PaymentMethod { get; set; }

        [Required]
        public int AppointmentsID { get; set; }

        [ForeignKey("AppointmentsID")]
        public virtual Appointments Appointments { get; set; }
    }
}
