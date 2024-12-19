using DOTNET_MVC_DUC_SHOP1c.Data;
using DOTNET_MVC_DUC_SHOP1c.Models;
using DOTNET_MVC_DUC_SHOP1c.Redis;
using DOTNET_MVC_DUC_SHOP1c.Repositories.Implementation;
using DOTNET_MVC_DUC_SHOP1c.Repositories.Interface;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using Rotativa.AspNetCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace DOTNET_MVC_DUC_SHOP1c
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
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddTransient<IHomeRepository, HomeRepository>();
            services.AddTransient<ICartRepository, CartRepository>();
            services.AddTransient<IGenericRepository<Category>, CategoryRepository>();
            services.AddTransient<IGenericRepos<ProvinceCity>, GenericRepos<ProvinceCity>>();
            services.AddTransient<IGenericRepository<District>, DistrictRepository>();
            services.AddTransient<IGenericRepository<Order>, OrderRepository>();
            //For Redis Cache
            services.AddScoped<IRedisCacheService, RedisCacheService>();

            services.AddDatabaseDeveloperPageExceptionFilter();

            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                 
                ;
            services.AddControllersWithViews();
			// For multi-language
			services.AddLocalization(opt => { opt.ResourcesPath = "Resources"; });
			services.AddMvc()
				.AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix)
				.AddDataAnnotationsLocalization();
			services.Configure<RequestLocalizationOptions>(
				opt =>
				{
					var supportedCultures = new[]
					{
					  new CultureInfo("en") ,
					  new CultureInfo("vi") ,
					};
					opt.DefaultRequestCulture = new RequestCulture("en");
					//opt.SupportedCultures = supportedCultures;
					opt.SupportedUICultures = supportedCultures;
				});
			// End for multi-language            
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();
			// For multi-language
			app.UseRequestLocalization();
			// End for multi-language 
			app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });

            // For Rotativa (PDF)
            RotativaConfiguration.Setup(env.WebRootPath, "Rotativa");
        }
    }
}
