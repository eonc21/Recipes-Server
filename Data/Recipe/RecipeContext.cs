using Microsoft.EntityFrameworkCore;
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
            
            base.OnModelCreating(modelBuilder);
        }
    }
}