
using System.ComponentModel.DataAnnotations;

namespace API.Dtos
{
    public class AddressDto
    {
        [Required]
        public string FistName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Street { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string State { get; set; }

        [Required]
        public string ZipCode { get; set; }
    }
}
