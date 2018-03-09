using RecipeFinder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace RecipeFinder.Controllers
{
    public class RecipeController : Controller
    {
        ApplicationDbContext _context = new ApplicationDbContext();
        RecipeRepository recipeRepo = new RecipeRepository(_context);

        [HttpPost]
        public ActionResult Create(Recipe recipe)
        {
            recipeRepo.AddRecipe(recipe);

            return RedirectToAction("Index", "Home");
        }
    }
}