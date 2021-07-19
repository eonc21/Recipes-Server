using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Recipes_Server.Data.Ingredient;
using Recipes_Server.Data.Recipe;
using Recipes_Server.Models;

namespace Recipes_Server.Repositories
{
    public class IngredientRepo : IIngredientRepo
    {
        private readonly RecipeContext _context;

        public IngredientRepo(RecipeContext context)
        {
            _context = context;
        }
        
        public IQueryable<Ingredient> GetIngredients()
        {
            return _context.Ingredients.Include(i => i.Recipes);
        }

        public Ingredient GetById(int id)
        {
            return _context.Ingredients.FirstOrDefault(ingredient => ingredient.Id == id);
        }

        public void DeleteIngredientById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void CreateIngredient()
        {
            throw new System.NotImplementedException();
        }
    }
}