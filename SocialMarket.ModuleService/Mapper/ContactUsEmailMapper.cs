using SocialMarket.Entity;
using SocialMarket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMarket.ModuleService.Mapper
{
    public static class ContactUsEmailMapper
    {
        public static ContactUsEmail ToContactUsEmail(this ContactusEmailModel source)
        {
            var dest = Mapping.Mapper.Map<ContactUsEmail>(source);
            return dest;
        }

        public static ContactusEmailModel ToContactusEmailModel(this ContactUsEmail source)
        {
            var dest = Mapping.Mapper.Map<ContactusEmailModel>(source);
            return dest;
        }
    }
}
