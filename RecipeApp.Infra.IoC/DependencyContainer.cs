using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RecipeApp.Infra.Data;
using RecipeApp.Infra.Data.Repositories;

namespace RecipeApp.Infra.IoC
{
    public static class DependencyContainer // DependencyContainer
    {
        public static void AddConsoleConfigurations(this IServiceCollection services, IConfiguration config)
        {
            // Add Console only configurations

            services.AddCommonConfigurations(config);
        }

        public static void AddApiConfigurations(this IServiceCollection services, IConfiguration config)
        {
            // Add Api only configurations

            services.AddCommonConfigurations(config);
        }

        public static void AddCommonConfigurations(this IServiceCollection services, IConfiguration config)
        {
            // Add configurations for all start up projects

            services.AddDbContext<RecipeDbContext>(options =>
            {
                options.UseSqlServer(config.GetConnectionString("RecipeDbConnection"));
            });

            services.RegisterServices(config);
        }

        public static void RegisterServices(this IServiceCollection services, IConfiguration config)
        {
            // Register your services here (repos, services, handlers, etc.)
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IRecipeRepository, RecipeRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IUserAdminRepository, UserAdminRepository>();


        }

    }
}
