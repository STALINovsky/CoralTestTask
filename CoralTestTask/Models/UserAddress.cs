using System.ComponentModel.DataAnnotations;

namespace CoralTestTask.Models
{
    public class UserAddress : Entity
    {
        [Required]
        public string Country { get; set; }

        [Required]
        [Display(Name = "Office name")]
        public string OfficeName { get; set; }
        
        [Required]
        public string Address { get; set; }
        
        [Required]
        [Display(Name = "Postal code")]
        public string PostalCode { get; set; }
        
        [Required]
        public string City { get; set; }

        [Required]
        public string State { get; set; }
    }
}
