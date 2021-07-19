using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Recipes_Server.Data.Ingredient
{
    public interface IIngredientRepo
    {
        IQueryable<Models.Ingredient> GetIngredients();
        Models.Ingredient GetById(int id);
        void DeleteIngredientById(int id);
        void CreateIngredient();
    }
}