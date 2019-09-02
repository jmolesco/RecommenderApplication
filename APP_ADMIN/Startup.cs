using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APP_ADMIN.Utility;
using APP_ADMIN.Validator;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json.Serialization;

namespace APP_ADMIN
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
            services.ConfigureDatabaseContext(this.Configuration);

            services.AddLocalizationService();

            services.AddMvc(opt =>
            {
                opt.Filters.Add(typeof(ValidateModelStateFilter));

            }).AddFluentValidation(fvc => fvc.RegisterValidatorsFromAssemblyContaining<Startup>())
              .AddJsonOptions(options => options.SerializerSettings.ContractResolver = new DefaultContractResolver())
              .AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix)
              .SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddEnvironment(this.Configuration);

            services.AddRepositoryService();
            services.AddDefaultServices();

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
                app.UseHsts();
            }
            //Enable Cors
            app.UseCors(x => x
               .AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader()
               .AllowCredentials());

            app.UseAuthentication();
            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
