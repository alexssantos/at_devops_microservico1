using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Taskfy.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

         public static IHostBuilder CreateHostBuilder(string[] args)
        {
            //WARNNING: Cloud Run expects for the app to listen on a PORT environment variable. 
            var port = Environment.GetEnvironmentVariable("PORT") ?? "5001";  // "8080";
            var url = $"http://0.0.0.0:{port}";

            return Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>()
                        .UseUrls(url);
                });
        }
    }
}
