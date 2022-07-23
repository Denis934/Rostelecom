using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace RostelecomApplication
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
                    webBuilder.UseStartup<Startup>(); // устанавливается стартовый класс приложения
                });
    }
}
