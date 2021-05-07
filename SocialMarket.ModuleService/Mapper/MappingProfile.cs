using AutoMapper;
using SocialMarket.Entity;
using SocialMarket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMarket.ModuleService.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //CreateMap<Source, Destination>();
            CreateMap<ContactusEmailModel, ContactUsEmail>();
            CreateMap<ContactUsEmail, ContactusEmailModel>();
            CreateMap<SocialProfile, SocialProfileModel>();
            // Additional mappings here...
        }
    }
}
