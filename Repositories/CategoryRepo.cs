using System.Collections.Generic;
using System.Linq;
using Recipes_Server.Data.Category;
using Recipes_Server.Data.Recipe;
using Recipes_Server.Models;

namespace Recipes_Server.Repositories
{
    public class CategoryRepo : ICategoryRepo
    {
        private readonly RecipeContext _context;

        public CategoryRepo(RecipeContext context)
        {
            _context = context;
        }
        
        public IQueryable<Category> GetCategories()
        {
            return _context.Categories;
        }
    }
}