using System.ComponentModel.DataAnnotations;
using Models;

namespace Staples.Models
{
    public class Person : IPerson
    {
        [Required(ErrorMessage = "Name is required.")]
        [StringLength(60, MinimumLength = 2)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Surname is required.")]
        [StringLength(60, MinimumLength = 2)]
        public string Surname { get; set; }
        [StringLength(60, MinimumLength = 2)]
        public string Address { get; set; }
        [StringLength(60, MinimumLength = 9)]
        public string PhoneNumber { get; set; }
    }
}
