using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RecipeApp.Domain.Model;
using RecipeApp.Domain.Models;
using RecipeApp.Infra.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeApp.Infra.IoC.Data
{
    public static class SeedData
    {
        public static IHost DbSeedData(this IHost host)
        {
            using var scope = host.Services.CreateScope();
            var services = scope.ServiceProvider;

            var context = services.GetRequiredService<RecipeDbContext>();
            context.Database.Migrate();
            SeedDataValues(context);
            return host;
        }

        private static void SeedDataValues(RecipeDbContext context)
        {
            if (!context.Recipes.Any())
            {
                context.AddRange(CreateTodos());
            }

            context.SaveChanges();
        }

        private static IEnumerable<Recipe> CreateTodos()
        {
            var list = new List<Recipe>();

            var roberto = new User()
            {
                Name = "Roberto Rocha",
                BirthDate = new DateTime(1987, 02, 16),
                UserAdmin = new User()
                {
                    UserName = "rrocha",
                    Password = "12345"
                }
            };

            var recipe01 = new Recipe()
            {
                Title = "Bifana de porco",
                Duration = "30 min",
                Owner = roberto
            };

            var meat = new Category()
            {
                Name = "Carne"
            };
            ((List<Category>)recipe01.Categories).Add(meat);

            var recipe02 = new Recipe()
            {
                Title = "Bacalhau com natas",
                Duration = "30 min",
                Owner = roberto
            };

            var fish = new Category()
            {
                Name = "Peixe"
            };
            ((List<Category>)recipe02.Categories).Add(fish);

            var joana = new User()
            {
                Name = "Joana",
                BirthDate = new DateTime(2000, 05, 15),
                UserAdmin = new UserAdmin()
                {
                    UserName = "jsantos",
                    Password = "12345"
                }
            };

            var recipe03 = new Recipe()
            {
                Title = "Sopa de pedra",
                Duration = "15 min",
                Owner = joana
            };
                       
            var soup = new Category()
            {
                Name = "Sopa"
            };
            ((List<Category>)recipe03.Categories).Add(soup);

            list.Add(recipe01);
            list.Add(recipe02);
            list.Add(recipe03);
            
            return list;
        }
    }
}
