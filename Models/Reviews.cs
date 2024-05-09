using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Licenta2.Models
{
    public class Reviews
    {
        /*[Key]
        public int Id { get; set; }

        [Required, MaxLength(1000)]
        public string Comment { get; set; }

        [Required]
        public decimal Rating { get; set; }

        [Required]
        public int UserID { get; set; } // cheie externa 
        
        [Required]
        public int UserID { get; set; }

         [ForeignKey("Id")]
        public virtual required ApplicationUser User { get; set; }

        [Required]
        public int ServiceID { get; set; } // cheie externa 

        [ForeignKey("ServiceID")]
        public virtual AppointmentServices Services { get; set; }*/

        [Key]
        public int ReviewID { get; set; }

        [Required]
        public int UserID { get; set; }

        public string? Comment { get; set; }

        [Required]
        public int Rating {  get; set; }
        public DateTime Date { get; set; } = DateTime.Now;

        [ForeignKey("Id")]
        public virtual required ApplicationUser User { get; set; }

        [Required]
        public int SeriviceId {  get; set; }

        [ForeignKey("ServiceId")]
        public virtual AppointmentServices AppointmentServices { get; set; }
    }
}
