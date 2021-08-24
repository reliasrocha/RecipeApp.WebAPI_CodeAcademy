using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeApp.Infra.Data.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity Create(TEntity obj);
        TEntity Delete(TEntity obj);
        IEnumerable<TEntity> Get();
        TEntity GetById(int id);
        TEntity Update(TEntity obj);
    }
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly RecipeDbContext context;
        protected DbSet<TEntity> DbSet;

        public Repository(RecipeDbContext context)
        {
            this.context = context;
            DbSet = context.Set<TEntity>();
        }
        public IEnumerable<TEntity> Get()
        {
            return DbSet.ToList();
        }
        public TEntity GetById(int id)
        {
            return DbSet.Find(id);
            //return context.Recipes.FirstOrDefault(recipe => recipe.Id == id);
        }
        public TEntity Create(TEntity obj)
        {
            DbSet.Add(obj);
            context.SaveChanges();
            return obj;
        }
        public TEntity Update(TEntity obj)
        {
            DbSet.Update(obj);
            context.SaveChanges();
            return obj;
        }
        public TEntity Delete(TEntity obj)
        {
            DbSet.Remove(obj);
            context.SaveChanges();
            return obj;
        }
    }
}
