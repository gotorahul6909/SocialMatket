using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMarket.Entity.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<ContactUsEmail> ContactUsEmail { get; set; }
        public DbSet<SocialProfile> SocialProfile { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Seed Profile Data
            modelBuilder.Entity<SocialProfile>().HasData(
                new SocialProfile { SocialProfileId = 1, Name = "Facebook", DisplayName = "Facebook" });
            modelBuilder.Entity<SocialProfile>().HasData(
                new SocialProfile { SocialProfileId = 2, Name = "LinkedIn", DisplayName = "Linked In" });
        }
    }
}
