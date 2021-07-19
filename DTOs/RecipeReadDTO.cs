using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;
using Recipes_Server.DTOs;

namespace Recipes_Server.DTOs
{
    public class RecipeReadDTO
    {
        public int Id { get; set; }
        
        public string Title { get; set; }
        
        public IEnumerable<IngredientReadDTO> Ingredients { get; set; }
        
        public string Instructions { get; set; }
        
        public DateTime AddedOn { get; set; }
        
    }
}