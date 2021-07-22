using System.ComponentModel.DataAnnotations;

namespace Recipes_Server.Models
{
    public class Category
    {
        [Required]
        [EnumDataType(typeof(CategoryEnum))]
        public CategoryEnum Name { get; set; }

        [Key]
        public int Id { get; set; }
        
        
        public enum CategoryEnum
        {
            Chicken,
            Pasta,
            Beef,
            Pork, 
            NoMeat
        }
    }
}