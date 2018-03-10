using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RecipeFinder.Models
{
    public class Recipe
    {
        public int RecipeId { get; set; }

        public string Name { get; set; }

        public string ShortDescription { get; set; }

        public List<Ingredient> Ingredients { get; set; }

        public string Instructions { get; set; }

        public HttpPostedFileBase Image { get; set; }

        public string ImageURL { get; set; }

        public virtual ApplicationUser User { get; set; }

        public string ApplicationUserId { get; set; }

        public Recipe()
        {
            Ingredients = new List<Ingredient>();
        }
    }
}