using Domain;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using Infrastracture.Interface;
using Infrastracture.Base;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Localization;
using System.Globalization;
using Utility.EnvironmentSettings;

namespace APP_ADMIN.Utility
{
    public static class ConfigureServiceExtensions
    {
        public static void ConfigureDatabaseContext(this IServiceCollection services, IConfiguration Configuration)
        {
            services.AddDbContext<DataContext>(opt =>
                  opt.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"))
            );
        }

        public static void AddRepositoryService(this IServiceCollection services)
        {
            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
        }

        public static void AddDefaultServices(this IServiceCollection services)
        {

            services.AddAutoMapper(typeof(Startup));
            services.AddHttpContextAccessor();

        }
        public static void AddEnvironment(this IServiceCollection services, IConfiguration configuration)
        {
            var appSettingsSection = configuration.GetSection("AppSettings");
            services.Configure<AdminAppSettings>(appSettingsSection);


            // put token here
        }

        public static void AddLocalizationService(this IServiceCollection services)
        {
            services.AddLocalization();
            var supportedCultures = new[]
            {
                    new CultureInfo("en-US"),
                    new CultureInfo("zh"),
                    new CultureInfo("ja-JP"),
                    new CultureInfo("ko-KR"),
            };

            services.Configure<RequestLocalizationOptions>(opt =>
            {
                opt.DefaultRequestCulture = new RequestCulture(new CultureInfo("en-US"));
                opt.SupportedCultures = supportedCultures;
                opt.SupportedUICultures = supportedCultures;
            });
        }

    }
}
