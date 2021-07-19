using System.Collections;
using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Recipes_Server.Data.Ingredient;
using Recipes_Server.DTOs;
using Recipes_Server.Models;
using Recipes_Server.Repositories;

namespace Recipes_Server.Controllers
{
    [Route("api/ingredients")]
    [ApiController]
    public class IngredientController : ControllerBase
    {
        private readonly IIngredientRepo _repo;
        private readonly IMapper _mapper;

        public IngredientController(IIngredientRepo repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        [HttpGet("getAll")]
        public ActionResult<IEnumerable<IngredientReadDTO>> GetIngredients()
        {
            var ingredients = _repo.GetIngredients();
            return Ok(_mapper.Map<IEnumerable<IngredientReadDTO>>(ingredients));
        }

        [HttpGet("{id}")]
        public ActionResult<Ingredient> GetById(int id)
        {
            var ingredient = _repo.GetById(id);
            return Ok(_mapper.Map<IngredientReadDTO>(ingredient));
        }
    }
}