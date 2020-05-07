using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Launchwares_API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    //webBuilder.UseKestrel(); // For InterNetwork uncomment this code.
                    //webBuilder.UseUrls("http://127.0.0.1:5000"); // For InterNetwork write your IP Adress instead of 127.0.0.1 and change port as you wish.
                    webBuilder.UseStartup<Startup>();
                });
    }
}