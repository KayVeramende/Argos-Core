using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Argos.Core.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Argos_Core
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var _host = CreateHostBuilder(args).Build();

            using (var scope = _host.Services.CreateScope())
            {
                try
                {
                    var _context = scope.ServiceProvider.GetService<ArgosDbContext>();
                    _context.Database.Migrate();
                }
                catch (Exception)
                {

                    throw;
                }
            }

            _host.Run();
        
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
