using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Recipes_Server.DTO;
using Recipes_Server.DTOs;
using Recipes_Server.Models;

namespace Recipes_Server.Profiles
{
    public class CommandsProfile : Profile
    {
        public CommandsProfile()
        {
            CreateMap<Ingredient, IngredientReadDTO>();
            CreateMap<IngredientReadDTO, Ingredient>();
            CreateMap<Recipe, RecipeReadDTO>();
            CreateMap<RecipeCreateDTO, Recipe>();
        }   
    }
}