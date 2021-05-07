using System;
using System.ComponentModel.DataAnnotations;

namespace SocialMarket.Models
{
    public class ContactusEmailModel
    {
        [Required]
        [MinLength(5)]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string Message { get; set; }
    }
}
