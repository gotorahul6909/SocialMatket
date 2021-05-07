using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMarket.Models
{
    public class SocialProfileModel
    {
        public int SocialProfileId { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
