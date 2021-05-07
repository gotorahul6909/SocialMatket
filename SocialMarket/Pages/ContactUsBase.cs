using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using SocialMarket.Models;
using SocialMarket.ModuleService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMarket.Pages
{
    public class ContactUsBase : ComponentBase
    {
        public string PageTitleText { get; set; } = "Contact Us";

        public ContactusEmailModel ContactusEmailModel { get; set; } = new ContactusEmailModel();

        [Inject]
        public IContactUsEmailService ContactUsEmailService { get; set; }

        [CascadingParameter]
        public Task<AuthenticationState> AuthenticationState { get; set; }

        protected async override Task OnInitializedAsync()
        {
            var authenticationState = await AuthenticationState;
            if (!authenticationState.User.Identity.IsAuthenticated)
            {
                Console.WriteLine("Not Authenticated");
            }
            else
            {
                Console.WriteLine("Authenticated");
            }
        }

        public async Task SaveContactUs()
        {
            var contactModel = await ContactUsEmailService.CheckContactUsEmailAsync(ContactusEmailModel.EmailAddress);
            if (contactModel != null)
            {
                //ModelState
            }
            else
            {
                var model = await ContactUsEmailService.AddContactusEmailModelAsync(ContactusEmailModel);
            }
        }
    }
}
