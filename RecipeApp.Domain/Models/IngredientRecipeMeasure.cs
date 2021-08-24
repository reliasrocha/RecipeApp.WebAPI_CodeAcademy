using System;
using System.Collections.Generic;

namespace RecipeApp.Domain.Models
{
    public class IngredientRecipeMeasure : IAuditable
    {
        public int Id { get; set; }
        public int IngredientId { get; set; }
        public int RecipeId { get; set; }
        public int MeasureUnitId { get; set; }
        public int Quantity { get; set; }
        public IEnumerable<Recipe> Recipes { get; set; }
        public DateTime CreationDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdateDate { get; set; }
        public string UpdatedBy { get; set; }
        public IngredientRecipeMeasure()
        {
            Recipes = new List<Recipe>();
            CreationDate = DateTime.Now;
        }
    }
}
