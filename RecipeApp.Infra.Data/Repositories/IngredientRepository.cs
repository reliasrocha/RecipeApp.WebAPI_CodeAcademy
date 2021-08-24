using RecipeApp.Domain.Models;

namespace RecipeApp.Infra.Data.Repositories
{
    public class IngredientRepository : Repository<Ingredient>, IIngredientRepository
    {
        public IngredientRepository(RecipeDbContext context) : base(context)
        {
        }
    }
}
