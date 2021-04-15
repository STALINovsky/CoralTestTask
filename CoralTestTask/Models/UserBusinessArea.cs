using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CoralTestTask.Models
{
    public class UserBusinessArea : Entity
    {
        public bool Finance { get; set; }
        public bool Operations { get; set; }
        public bool IT { get; set; }
        public bool Sales { get; set; }
        public bool Administrative { get; set; }
        public bool Legal { get; set; }
        public bool Marketing { get; set; }

        [Required]
        public string Comments { get; set; }
    }
}
