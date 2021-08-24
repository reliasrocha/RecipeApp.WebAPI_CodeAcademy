using RecipeApp.Domain.Models;

namespace RecipeApp.Infra.Data.Repositories
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(RecipeDbContext context) : base(context)
        {
        }
    }
}
