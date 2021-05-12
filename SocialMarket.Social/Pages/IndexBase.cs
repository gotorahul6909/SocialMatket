using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Identity;
using SocialMarket.Social.FbService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMarket.Social.Pages
{
    public class IndexBase : ComponentBase
    {
        [Inject]
        public IFbAccessToken FbAccessToken { get; set; }

        [Inject]
        public SignInManager<IdentityUser> _signInManager { get; set; }

        protected async override Task OnInitializedAsync()
        {
            var dd = await _signInManager.GetExternalLoginInfoAsync();
            if (dd != null)
            {
                await this.FbAccessToken.FbAccToken();
            }
        }
    }
}
