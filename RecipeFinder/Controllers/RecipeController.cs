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
        private readonly ApplicationDbContext _context;
        private ApplicationSignInManager _signInManager;
        private ApplicationUserManager _userManager;

        public RecipeController(ApplicationDbContext context, ApplicationUserManager userManager, ApplicationSignInManager signInManager)
        {
            _context = context;
            _signInManager = signInManager;
            _userManager = userManager;
        }

        //RecipeRepository recipeRepo = new RecipeRepository(_context);

        [HttpPost]
        public ActionResult Create(RecipeViewModel recipeView)
        {
            string path = Server.MapPath("~/Content/images/" + recipeView.Image.FileName);

            recipeView.Image.SaveAs(path);

            

            Recipe recipe = new Recipe()
            {
                Name = recipeView.Name,
                ShortDescription = recipeView.ShortDescription,
                ImageURL = path,
                User = UserMana
            };

            return RedirectToAction("Index", "Home");
        }
    }
}