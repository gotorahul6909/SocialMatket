using SocialMarket.Models;
using System.Threading.Tasks;

namespace SocialMarket.ModuleService
{
    public interface IContactUsEmailService
    {
        Task<ContactusEmailModel> AddContactusEmailModelAsync(ContactusEmailModel source);
        Task<ContactusEmailModel> CheckContactUsEmailAsync(string email);
    }
}