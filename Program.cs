using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Steeltoe.Extensions.Configuration.ConfigServer;
using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using Unity.Microsoft.DependencyInjection;

namespace OrderStatusService.Api
{
    [ExcludeFromCodeCoverage]
    public static class Program
    {
        public static void Main(string[] args)
        {
            AppContext.SetSwitch("System.Net.Http.UseSocketsHttpHandler", false);
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateWebHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseConfiguration(new ConfigurationBuilder().AddCommandLine(args).Build());
                    webBuilder.UseContentRoot(Directory.GetCurrentDirectory());
                    webBuilder.AddConfigServer();
                    webBuilder.UseUnityServiceProvider();
                    webBuilder.UseStartup<Startup>();
                })
                .ConfigureServices(services =>
                {
                    //services.AddHostedService<RabbitMQService>();
                });
    }
}