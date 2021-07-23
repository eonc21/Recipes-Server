using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Recipes_Server.Data.Category;
using Recipes_Server.Models;
using Recipes_Server.Repositories;

namespace Recipes_Server.Controllers
{
    [Route("api/categories")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryRepo _repo;

        public CategoryController(ICategoryRepo repo)
        {
            _repo = repo;
        }


        [HttpGet("getAll")]
        public IQueryable<Category> GetCategories()
        {
            return _repo.GetCategories();
        }
    }
}