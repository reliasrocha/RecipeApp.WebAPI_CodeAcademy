using RecipeApp.Domain.Models;

namespace RecipeApp.Infra.Data.Repositories
{
    class MeasureUnitRepository : Repository<MeasureUnit>, IRepository<MeasureUnit>
    {
        public MeasureUnitRepository(RecipeDbContext context) : base(context)
        {
        }
    }
}
