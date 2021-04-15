using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace CoralTestTask.Models
{
    public class UserContactInfo : Entity
    {
        [Required]
        public string Salutation { get; set; }
        [Required]
        [Display(Name = "First name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Middle name")]
        public string MiddleName { get; set; }
        [Required]
        [Display(Name = "Last name")]
        public string LastName { get; set; }

        [Required]
        public string Company { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        public string Phone { get; set; }

        public string Fax { get; set; }

        [Phone]
        [Display(Name = "Mobile")]
        public string MobilePhone { get; set; }
    }
}
