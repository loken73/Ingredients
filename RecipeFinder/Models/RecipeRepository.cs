using RecipeFinder.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RecipeFinder.Models
{

    public class RecipeRepository : IRecipeRepository
    {
        private readonly ApplicationDbContext _context;

        public RecipeRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Recipe> GetRecipes(int page = 1, int pageSize = 9)
        {
            return _context.Recipes
                    .Include(r => r.User)
                    .Skip((page - 1) * pageSize)
                    .Take(pageSize)
                    .ToList();
        }

        public Recipe GetRecipeById(int id)
        {
            return _context.Recipes.FirstOrDefault(recipe => recipe.RecipeId == id);
        }

        public void AddRecipe(Recipe recipe)
        {
            _context.Recipes.Add(recipe);
        }

        
    }
}