using csharp_job_finder.Data;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace csharp_job_finder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = BuildeWebHost(args);

            using (var scope = host.Services.CreateScope())
            using (var context = scope.ServiceProvider.GetService<csharp_job_finderContext>())
            {
                context.Database.EnsureCreated();
            }

            host.Run();
        }

        public static IWebHost BuildeWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
