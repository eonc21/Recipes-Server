using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;
using Recipes_Server.DTOs;

namespace Recipes_Server.Models
{
    public class Recipe
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Title { get; set; }
        
        [Required]
        public IEnumerable<Ingredient> Ingredients { get; set; }
        
        [Required]
        public string Instructions { get; set; }
        
        [Required]
        public DateTime AddedOn { get; set; }
        
        [Required]
        public string Description { get; set; }
        
        [Required]
        public string PictureLink { get; set; }
        
        [Required]
        public IEnumerable<Category> Categories { get; set; }

    }
}