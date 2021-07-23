using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace Recipes_Server.Models
{
    public class Category
    {
        [Required]
        public CategoryEnum Name { get; set; }

        [Required]
        public string StringName
        {
            get
            {
                return Name.ToString();
            }
        }

        [Key]
        public int Id { get; set; }
        
        // [JsonConverter(typeof(StringEnumConverter<Category, string, CategoryEnum>))]
        public enum CategoryEnum
        {
            Chicken = 1,
            Pasta = 2,
            Beef = 3,
            Pork = 4, 
            NoMeat = 5
        }
        
        
    }
}