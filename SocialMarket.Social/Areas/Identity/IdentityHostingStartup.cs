using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SocialMarket.Social.Data;

[assembly: HostingStartup(typeof(SocialMarket.Social.Areas.Identity.IdentityHostingStartup))]
namespace SocialMarket.Social.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<SocialMarketSocialContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("SocialMarketSocialContextConnection")));

                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<SocialMarketSocialContext>();
            });
        }
    }
}