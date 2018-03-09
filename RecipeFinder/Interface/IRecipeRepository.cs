﻿using RecipeFinder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeFinder.Interface
{
    interface IRecipeRepository
    {
        IEnumerable<Recipe> GetAllRecipes();

        Recipe GetRecipeById(int id);

        void AddRecipe(Recipe recipe);
    }
}
