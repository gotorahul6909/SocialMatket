using System;
using System.ComponentModel.DataAnnotations;

namespace SocialMarket.Entity
{
    public class ContactUsEmail
    {
        public int ContactUsEmailId { get; set; }
        [Required]
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
