using SocialMarket.Entity;
using SocialMarket.Models;
using SocialMarket.ModuleService.Mapper;
using SocialMarket.Repo;
using System;
using System.Threading.Tasks;

namespace SocialMarket.ModuleService
{
    public class ContactUsEmailService : IContactUsEmailService
    {
        private readonly ContactUsRepo contactUsRepo;

        public ContactUsEmailService(ContactUsRepo contactUsRepo)
        {
            this.contactUsRepo = contactUsRepo;
        }

        public async Task<ContactusEmailModel> AddContactusEmailModelAsync(ContactusEmailModel source)
        {
            var model = await this.contactUsRepo.AddAsync(source.ToContactUsEmail());
            var result = model.ToContactusEmailModel();
            return result;
        }

        public async Task<ContactusEmailModel> CheckContactUsEmailAsync(string email)
        {
            return (await this.contactUsRepo.CheckContactUsEmailAsync(email)).ToContactusEmailModel();
        }
    }
}
