using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Recipes_Server.Data;
using Recipes_Server.Data.Recipe;
using Recipes_Server.Models;

namespace Recipes_Server.Repositories
{
    public class RecipeRepo : IRecipeRepo
    {

        private readonly RecipeContext _context;
        
        public RecipeRepo(RecipeContext context)
        {
            _context = context;
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public IEnumerable<Recipe> GetRecipes()
        {
            return _context.Recipes.Include(r => r.Ingredients).Include(c => c.Categories);
        }

        public Recipe GetRecipeById(int id)
        {
            return _context.Recipes.Include(r => r.Ingredients).FirstOrDefault(recipe => recipe.Id == id);
        }

        public void DeleteRecipeById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void CreateRecipe(Recipe recipe)
        {
            if (recipe == null)
            {
                throw new ArgumentNullException(nameof(recipe));
            }

            _context.Recipes.Add(recipe);
        }
    }
}