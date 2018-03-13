using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RecipeFinder.Models
{
    public class RecipeViewModel
    {
        public string Name { get; set; }

        public string ShortDescription { get; set; }

        public string Ingredients { get; set; }

        public string Instructions { get; set; }

        public HttpPostedFileBase Image { get; set; }
    }
}