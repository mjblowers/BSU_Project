
using BSU_BackpackToGithub.Data;
using BSU_BackpackToGithub.Models;
using BSUGitBackPack.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace BSU_BackpackToGithub
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddDbContext<BSUStudentContext>(options =>
            options.UseSqlite(Configuration.GetConnectionString("BSUStudentContext"))
            );
            services.AddDbContext<AppDbContext>(options =>
           options.UseSqlite(Configuration.GetConnectionString("AppDbContext"))
           );
            services.AddIdentity<IdentityUser, IdentityRole>(options =>
          {
              options.Password.RequireNonAlphanumeric = false;
              options.Password.RequireUppercase = false;
              options.Password.RequireDigit = false;
              options.Password.RequiredUniqueChars = 0;
          }).AddEntityFrameworkStores<AppDbContext>();

            services.AddAuthentication()               
        .AddGoogle(options =>
        {
           var googleClientId = Environment.GetEnvironmentVariable("Shane_Google_Oauth_Id");
           var googleClientSecret = Environment.GetEnvironmentVariable("Shane_Google_Oauth_Secret");
           options.ClientId = googleClientId;
           options.ClientSecret = googleClientSecret;
        });


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseAuthentication();
            

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Login}/{id?}");
            });
        }
    }
}
