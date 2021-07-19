using System.Collections;
using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Recipes_Server.Data;
using Recipes_Server.Data.Recipe;
using Recipes_Server.DTO;
using Recipes_Server.DTOs;
using Recipes_Server.Models;

namespace Recipes_Server.Controllers
{
    [Route("api/recipes")]
    [ApiController]
    public class RecipeController : ControllerBase
    {
        private readonly IRecipeRepo _repo;
        private readonly IMapper _mapper;

        public RecipeController(IRecipeRepo repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        [HttpGet("getAll")]
        public ActionResult<IEnumerable<RecipeReadDTO>> GetRecipes()
        {

            var recipes = _repo.GetRecipes();
            return Ok(_mapper.Map<IEnumerable<RecipeReadDTO>>(recipes));

        }
        
        [HttpGet("{id}")]
        public ActionResult<IEnumerable<RecipeReadDTO>> GetRecipeById(int id)
        {
            var recipe = _repo.GetRecipeById(id);
            return Ok(_mapper.Map<RecipeReadDTO>(recipe));

        }

        [HttpPost]
        public ActionResult<RecipeReadDTO> CreateRecipe(RecipeCreateDTO recipeCreateDto)
        {
            var recipe = _mapper.Map<Recipe>(recipeCreateDto);
            _repo.CreateRecipe(recipe);
            _repo.SaveChanges();

            return Ok();
        }
    }
}