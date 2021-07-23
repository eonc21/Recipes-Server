using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;
using Recipes_Server.DTOs;
using Recipes_Server.Models;

namespace Recipes_Server.DTO

{
    public class RecipeCreateDTO
    {

        public string Title { get; set; }
        
        public IEnumerable<IngredientReadDTO> Ingredients { get; set; }
        
        public string Instructions { get; set; }
        
        public DateTime AddedOn { get; set; }
        
        public string Description { get; set; }
        
        public string PictureLink { get; set; }
        
        public IEnumerable<CategoryReadDTO> Categories { get; set; }


        
    }
}