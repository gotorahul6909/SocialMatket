using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMarket.Entity
{
    public class SocialProfile
    {
        public int SocialProfileId { get; set; }
        [Required]
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Logo { get; set; }
    }
}
