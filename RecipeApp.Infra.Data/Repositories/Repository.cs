using System.Collections.Generic;

namespace RecipeApp.Infra.Data.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private RecipeDbContext context;

        public Repository(RecipeDbContext context)
        {
            this.context = context;
        }

        public TEntity Create(TEntity obj)
        {
            throw new System.NotImplementedException();
        }

        public TEntity Delete(TEntity obj)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<TEntity> Get()
        {
            throw new System.NotImplementedException();
        }

        public TEntity GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public TEntity Update(TEntity obj)
        {
            throw new System.NotImplementedException();
        }
    }
}
