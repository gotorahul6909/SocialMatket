using SocialMarket.Entity;
using SocialMarket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMarket.ModuleService.Mapper
{
    public static class SocialProfileMapper
    {
        public static List<SocialProfileModel> ToSocialProfileModelList(this List<SocialProfile> source)
        {
            var dest = Mapping.Mapper.Map<List<SocialProfileModel>>(source);
            return dest;
        }

        public static SocialProfileModel ToSocialProfileModel(this SocialProfile source)
        {
            var dest = Mapping.Mapper.Map<SocialProfileModel>(source);
            return dest;
        }
    }
}
