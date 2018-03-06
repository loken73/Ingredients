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

<<<<<<< HEAD
        public virtual ApplicationUser User { get; set; }

        public string ApplicationUserId { get; set; }

=======
>>>>>>> 96883119ed277f18bde842bdf466aa3cb55fde0f
        public Recipe()
        {
            Ingredients = new List<Ingredient>();
        }
    }
}