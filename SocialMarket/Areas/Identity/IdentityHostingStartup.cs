using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SocialMarket.Data;

[assembly: HostingStartup(typeof(SocialMarket.Areas.Identity.IdentityHostingStartup))]
namespace SocialMarket.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<SocialMarketContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("SocialMarketContextConnection")));

                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<SocialMarketContext>();
            });
        }
    }
}