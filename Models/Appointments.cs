using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Licenta2.Models
{
    public class Appointments
    {
        /* [Key]
         public int Id { get; set; }

         [Required]
         public int UserID { get; set; }

         //[ForeignKey("Id")]
         //public virtual ApplicationUser Users { get; set; }

         [Required]
         public int ServicesId { get; set; }

         [ForeignKey("ServicesId")]
         public virtual AppointmentServices Services { get; set; }

         [Required]
         public int AppointmentTimeId { get; set; }

         [ForeignKey("AppointTimeId")]
         public virtual AppointmentTime AppointmentTime { get; set; }*/

        [Key]
        public int AppointmentsID { get; set; }

        [Required]
        public int UserID { get; set; }

        [ForeignKey("Id")]
        public virtual required ApplicationUser User { get; set; }

        [Required]
        public int ServicesId {  get; set; }

        [ForeignKey("ServicesId")]
        public virtual AppointmentServices AppointmentServices { get; set; }

        [Required]
        public int AppointmentTimeId {  get; set; }

        [ForeignKey("AppointmentTimeId")]
        public virtual AppointmentTime AppointmentTime { get; set; }

    }
}
