using SocialMarket.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SocialMarket.ModuleService
{
    public interface ISocialProfileService
    {
        Task<List<SocialProfileModel>> GetAll();
    }
}