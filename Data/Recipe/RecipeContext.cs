using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Recipes_Server.Models;
namespace Recipes_Server.Data.Recipe

{
    public class RecipeContext : DbContext
    {
        public RecipeContext(DbContextOptions<RecipeContext> opt) : base(opt)
        {
        }

        public DbSet<Models.Recipe> Recipes { get; set; }
        public DbSet<Models.Ingredient> Ingredients { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Models.Recipe>()
                .HasMany(r => r.Ingredients)
                .WithMany(i => i.Recipes);

            modelBuilder
                .Entity<Models.Recipe>()
                .HasOne(r => r.Category);
                // .WithMany(i => i.Recipes);
                
                modelBuilder
                .Entity<Category>()
                .Property(d => d.Name)
                .HasConversion(new EnumToStringConverter<Category.CategoryEnum>());

                base.OnModelCreating(modelBuilder);
        }
    }
}