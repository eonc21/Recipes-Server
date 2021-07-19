using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Recipes_Server.Models;

namespace Recipes_Server.DTOs
{
    public class IngredientReadDTO
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        
    }
}