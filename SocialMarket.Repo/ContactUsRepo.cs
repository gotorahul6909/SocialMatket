using Microsoft.EntityFrameworkCore;
using SocialMarket.Entity;
using SocialMarket.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMarket.Repo
{
    public class ContactUsRepo : Repository<ContactUsEmail>
    {
        private readonly AppDbContext context;

        public ContactUsRepo(AppDbContext context) : base(context)
        {
            this.context = context;
        }

        public async Task<ContactUsEmail> CheckContactUsEmailAsync(string email)
        {
            return await context.ContactUsEmail.FirstOrDefaultAsync(x=>x.EmailAddress == email);
        }
    }
}
