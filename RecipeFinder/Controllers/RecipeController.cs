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

        public RecipeController(ApplicationDbContext context)
        {
            _context = context;
        }

        //RecipeRepository recipeRepo = new RecipeRepository(_context);

        [HttpPost]
        public ActionResult Create(RecipeViewModel recipe)
        {
            string path = Server.MapPath("~/Content/images/" + recipe.Image.FileName);

            recipe.Image.SaveAs(path); 

            return RedirectToAction("Index", "Home");
        }
    }
}