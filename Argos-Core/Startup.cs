using Argos.Core.Data;
using Argos.Core.Repository.IRepository.Master;
using Argos.Core.Repository.Master;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace Argos_Core
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
            services.AddDbContextPool<ArgosDbContext>(opt =>
            {
                opt.UseSqlServer(Configuration.GetConnectionString("ArgosCoreDB"), x => x.MigrationsAssembly("Argos.Core.Data"));
            });

            services.AddScoped<IFleetRepository, FleetRepository>();

            //Content negotiation 
            services.AddControllers(setUp =>
            {
                setUp.ReturnHttpNotAcceptable = true;
                setUp.OutputFormatters.Add(new XmlDataContractSerializerOutputFormatter());
            }).AddXmlSerializerFormatters();

            //Adding automapper 
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
