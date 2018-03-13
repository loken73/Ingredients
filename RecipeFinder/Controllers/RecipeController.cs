using Microsoft.AspNet.Identity.Owin;
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
        //private ApplicationSignInManager _signInManager;
        private ApplicationUserManager _userManager;

        public RecipeController()
        {
        }

        public RecipeController(ApplicationDbContext context, ApplicationUserManager userManager, ApplicationSignInManager signInManager)
        {
            _context = context;
            //_signInManager = signInManager;
            UserManager = userManager;
        }

        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }

        //RecipeRepository recipeRepo = new RecipeRepository(_context);

        public ActionResult Create ()
        {
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public async Task<ActionResult> Create(RecipeViewModel recipeView, HttpPostedFileBase RecipeImage)
        {
            string path = Server.MapPath("~/Content/images/" + RecipeImage.FileName);

            RecipeImage.SaveAs(path);

            var currentUser = await UserManager.FindByNameAsync(User.Identity.Name);

            var b = recipeView.Ingredients;

            Recipe recipe = new Recipe()
            {
                Name = recipeView.Name,
                ShortDescription = recipeView.ShortDescription,
                ImageURL = path,
                User = currentUser,
                Instructions = recipeView.Instructions
            };

            return RedirectToAction("Index", "Home");
        }
    }
}