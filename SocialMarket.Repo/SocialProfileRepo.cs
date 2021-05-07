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
    public class SocialProfileRepo : Repository<SocialProfile>
    {
        private readonly AppDbContext context;

        public SocialProfileRepo(AppDbContext context) : base(context)
        {
            this.context = context;
        }
    }
}
