using RecipeApp.Domain.Models;

namespace RecipeApp.Infra.Data.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(RecipeDbContext context) : base(context)
        {
        }
    }
}
