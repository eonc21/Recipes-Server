using System.ComponentModel.DataAnnotations;
using Recipes_Server.Models;

namespace Recipes_Server.DTOs
{
    public class CategoryReadDTO
    {
        public int Id { get; set; }
        public Category.CategoryEnum Name { get; set; }

        public string StringName
        {
            get;
            set;
        }
        
        
        
        
    }
}