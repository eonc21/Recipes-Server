using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Recipes_Server.Models
{
    public class Ingredient
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }
        
        [Required]
        public IEnumerable<Recipe> Recipes { get; set;  } 
    }
}