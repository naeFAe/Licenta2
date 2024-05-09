using Microsoft.AspNetCore.Identity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Licenta2.Models
{
    public class ApplicationUser :IdentityUser
    {
    

        [Required, MaxLength(50)]
        public string FirstName { get; set; }

        [Required, MaxLength(50)]
        public string LastName { get; set; }

        [Required, MaxLength(100)]
        [EmailAddress]
        public string Email { get; set; }

        [Required, DataType(DataType.Date)]
        [DisplayName("Birth Date")]
        public DateTime BirthDate { get; set; }

        [Required]
        public string RoleName {  get; set; }
    }
}
