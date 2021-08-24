using System;
using System.Collections.Generic;

namespace RecipeApp.Domain.Models
{
    public class User : IAuditable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int UserAdminId { get; set; }
        public UserAdmin UserAdmin { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime CreationDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdateDate { get; set; }
        public string UpdatedBy { get; set; }
        public IEnumerable<Recipe> Recipes { get; set; }

        public User()
        {
            Recipes = new List<Recipe>();
            CreationDate = DateTime.Now;
        }
    }
}
