using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeApp.Domain.Models
{
    public class Recipe : IAuditable
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }
        public string Duration { get; set; }
        public int OwnerId { get; set; }
        public User Owner { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Rating> Ratings { get; set; }
        public IEnumerable<Ingredient> Ingredients { get; set; }
        public IEnumerable<MeasureUnit> MeasureUnits { get; set; }
        public IEnumerable<IngredientRecipeMeasure> IngredientRecipeMeasures { get; set; }
        public DateTime CreationDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdateDate { get; set; }
        public string UpdatedBy { get; set; }
    }
}
