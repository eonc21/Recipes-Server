using System.Linq;

namespace Recipes_Server.Data.Category
{
    public interface ICategoryRepo
    {
        IQueryable<Models.Category> GetCategories();

    }
}