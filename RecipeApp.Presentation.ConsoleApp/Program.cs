using Microsoft.Extensions.DependencyInjection;
using RecipeApp.Presentation.ConsoleApp.Configurations;
using System;


namespace RecipeApp.Presentation.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var services = ServicesExtensions.RegisterServices();

            var serviceProvider = services.BuildServiceProvider();

            serviceProvider.GetService<StartUp>().Run(args);
        }
    }
}
