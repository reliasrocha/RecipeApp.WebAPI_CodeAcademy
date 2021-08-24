using RecipeApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeApp.Infra.Data.Repositories
{
    public interface IRecipeRepository : IRepository<Recipe>
    {
    }
}
