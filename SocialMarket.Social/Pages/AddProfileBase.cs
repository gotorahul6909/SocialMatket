using Microsoft.AspNetCore.Components;
using SocialMarket.Models;
using SocialMarket.ModuleService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMarket.Social.Pages
{
    public class AddProfileBase : ComponentBase
    {
        [Inject]
        public ISocialProfileService SocialProfileService { get; set; }

        public List<SocialProfileModel> AllSocial { get; set; }

        protected async override Task OnInitializedAsync()
        {
            await AllSocialProfiles();
        }

        private async Task AllSocialProfiles()
        {
            AllSocial = await this.SocialProfileService.GetAll();
        }
    }
}
