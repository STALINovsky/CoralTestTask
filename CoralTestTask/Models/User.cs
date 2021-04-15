using System.ComponentModel.DataAnnotations;

namespace CoralTestTask.Models
{
    public class User : Entity
    {
        [Required]
        public UserContactInfo ContactInfo { get; set; }
        [Required]
        public UserAddress Address { get; set; }
        [Required]
        public UserBusinessArea BusinessArea { get; set; }

    }
}
