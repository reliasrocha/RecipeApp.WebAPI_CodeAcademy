using Microsoft.EntityFrameworkCore;
using RecipeApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeApp.Infra.Data
{
    public class RecipeDbContext : DbContext
    {
        public RecipeDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<MeasureUnit> MeasureUnits { get; set; }
        public DbSet<IngredientRecipeMeasure> IngredientRecipeMeasures { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(RecipeDbContext).Assembly);
        }
    }
}
