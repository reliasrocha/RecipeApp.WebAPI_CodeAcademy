using RecipeApp.Domain.Models;

namespace RecipeApp.Infra.Data.Repositories
{
    public class UserAdminRepository : Repository<UserAdmin>, IUserAdminRepository
    {
        public UserAdminRepository(RecipeDbContext context) : base(context)
        {
        }
    }
}
