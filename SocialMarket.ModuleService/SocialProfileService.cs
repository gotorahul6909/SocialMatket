using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocialMarket.Models;
using SocialMarket.ModuleService.Mapper;
using SocialMarket.Repo;

namespace SocialMarket.ModuleService
{
    public class SocialProfileService : ISocialProfileService
    {
        private readonly SocialProfileRepo socialProfileRepo;

        public SocialProfileService(SocialProfileRepo socialProfileRepo)
        {
            this.socialProfileRepo = socialProfileRepo;
        }

        public async Task<List<SocialProfileModel>> GetAll()
        {
            var model = await this.socialProfileRepo.GetAll();
            var result = model.ToList()
                .ConvertAll(new Converter<Entity.SocialProfile, SocialProfileModel>(SocialProfileMapper.ToSocialProfileModel));
            return result;
        }
    }
}
