using System;
using System.Collections.Generic;

namespace RecipeApp.Domain.Models
{
    public class MeasureUnit : IAuditable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<Recipe> Recipes { get; set; }
        public DateTime CreationDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdateDate { get; set; }
        public string UpdatedBy { get; set; }

        public MeasureUnit()
        {
            Recipes = new List<Recipe>();
            CreationDate = DateTime.Now;
        }
    }
}
