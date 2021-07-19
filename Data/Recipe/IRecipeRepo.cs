using System.Collections;
using System.Collections.Generic;
using Recipes_Server.Models;

namespace Recipes_Server.Data.Recipe
{
    public interface IRecipeRepo
    {
        bool SaveChanges();
        IEnumerable<Models.Recipe> GetRecipes();
        Models.Recipe GetRecipeById(int id);
        void DeleteRecipeById(int id);
        void CreateRecipe(Models.Recipe recipe);

    }
}