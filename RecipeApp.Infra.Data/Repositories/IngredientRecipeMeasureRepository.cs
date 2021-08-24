using RecipeApp.Domain.Models;

namespace RecipeApp.Infra.Data.Repositories
{
    class IngredientRecipeMeasureRepository : Repository<IngredientRecipeMeasure>, IIngredientRecipeMeasure
    {
        public IngredientRecipeMeasureRepository(RecipeDbContext context) : base(context)
        {
        }
    }
}
