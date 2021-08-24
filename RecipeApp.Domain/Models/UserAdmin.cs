using System;
using System.Collections.Generic;

namespace RecipeApp.Domain.Models
{
    public class UserAdmin : IAuditable
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int TaxNumber { get; set; }
        public int EmployeeNumber { get; set; }
        public DateTime CreationDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdateDate { get; set; }
        public string UpdatedBy { get; set; }
        public IEnumerable<Recipe> Recipes { get; set; }

        public UserAdmin()
        {
            Recipes = new List<Recipe>();
            CreationDate = DateTime.Now;
        }
    }
}
