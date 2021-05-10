using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Identity;
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
        public SocialProfileModel SocialProfileModel { get; set; }

        public SocialModel SocialModel { get; set; }

        [Inject]
        public SignInManager<IdentityUser> _signInManager { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }

        protected async override Task OnInitializedAsync()
        {
            await AllSocialProfiles();
        }

        private async Task AllSocialProfiles()
        {
            AllSocial = await this.SocialProfileService.GetAll();
        }

        protected void GetProvider(SocialProfileModel socialProfileModel)
        {
            //NavigationManager.NavigateTo($"/Identity/Account/ExternalLogin/OnGetData?provider={socialProfileModel.Name}", true);
            NavigationManager.NavigateTo($"/SocialRedirect/SocialRedirects?provider={socialProfileModel.Name}", true);
        }
    }
}
