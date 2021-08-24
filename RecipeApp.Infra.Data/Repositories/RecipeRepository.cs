using RecipeApp.Domain.Models;

namespace RecipeApp.Infra.Data.Repositories
{
    public class RecipeRepository : Repository<Recipe>, IRecipeRepository
    {
        public RecipeRepository(RecipeDbContext context) : base(context)
        {
        }
    }
}
