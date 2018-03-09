using RecipeFinder.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RecipeFinder.Models
{

    public class RecipeRepository : IRecipeRepository
    {
        private readonly ApplicationDbContext _context;

        public IEnumerable<Recipe> GetAllRecipes()
        {
            return _context.Recipes.ToList();
        }

        public Recipe GetRecipeById(int id)
        {
            return _context.Recipes.FirstOrDefault(recipe => recipe.RecipeId == id);
        }

        public void AddRecipe(Recipe recipe)
        {
            _context.Recipes.Add(recipe);
            _context.SaveChangesAsync();
        }

        public RecipeRepository(ApplicationDbContext context)
        {
            _context = context;
        }
    }
}