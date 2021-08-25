using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RecipeApp.Infra.Data;
using RecipeApp.Infra.Data.Repositories;
using RecipeApp.Infra.IoC;

namespace RecipeApp.Presentation.ConsoleApp.Configurations
{
    public class ServicesExtensions
    {
        public static IServiceCollection RegisterServices()
        {
            IServiceCollection services = new ServiceCollection();

            IConfiguration _config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddEnvironmentVariables()
                .Build();

            // Register all services here
            services.AddScoped<StartUp>();
            services.AddScoped<UserConsole>();

            services.AddApiConfigurations(_config);

            return services;
        }
    }
}
