using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Recipes_Server.Data;
using Recipes_Server.Data.Category;
using Recipes_Server.Data.Ingredient;
using Recipes_Server.Data.Recipe;
using Recipes_Server.Repositories;


namespace Recipes_Server
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddDbContext<RecipeContext>(opt =>
            {
                opt.UseNpgsql(GetConnectionString());
            });
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Recipes_Server", Version = "v1" });
            });

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddScoped<IRecipeRepo, RecipeRepo>();
            services.AddScoped<IIngredientRepo, IngredientRepo>();
            services.AddScoped<ICategoryRepo, CategoryRepo>();
            services.AddCors();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                // app.UseSwagger();
                // app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Recipes_Server v1"));
            }

            // app.UseHttpsRedirection();
            
            app.UseRouting();

            app.UseAuthorization();

            app.UseCors(builder => builder
                .AllowAnyOrigin());
            

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
        
        
        private string GetConnectionString()
        {
            var connectionUrl = Configuration["DATABASE_URL"];

            if (connectionUrl is null)
                return
                    "Server=localhost;Port=5432;Database=recipes;User Id=recipes_api;Password=recipes_api_password";

            // parse the connection string
            var databaseUri = new Uri(connectionUrl);

            var db = databaseUri.LocalPath.TrimStart('/');
            var userInfo = databaseUri.UserInfo.Split(':', StringSplitOptions.RemoveEmptyEntries);

            return
                $"User ID={userInfo[0]};Password={userInfo[1]};Host={databaseUri.Host};Port={databaseUri.Port};" +
                $"Database={db};Pooling=true;SSL Mode=Require;Trust Server Certificate=True;";
        }
    }
}
