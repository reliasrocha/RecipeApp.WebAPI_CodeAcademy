using RecipeApp.Domain.Models;

namespace RecipeApp.Infra.Data.Repositories
{
    public class RatingRepository : Repository<Rating>, IRatingRepository
    {
        public RatingRepository(RecipeDbContext context) : base(context)
        {
        }
    }
}
