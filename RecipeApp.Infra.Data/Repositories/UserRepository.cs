using RecipeApp.Domain.Models;

namespace RecipeApp.Infra.Data.Repositories
{
    class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(RecipeDbContext context) : base(context)
        {
        }
    }
}
