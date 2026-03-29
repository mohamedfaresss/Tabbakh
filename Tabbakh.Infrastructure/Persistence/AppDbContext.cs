using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tabbakh.Domain.Entities;

namespace Tabbakh.Infrastructure.Persistence
{
    public class AppDbContext : IdentityDbContext
    {

        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<RecipeTranslation> RecipeTranslations { get; set; }

        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<IngredientTranslation> IngredientTranslations { get; set; }

        public DbSet<RecipeIngredient> RecipeIngredients { get; set; }

        public DbSet<RecipeLike> RecipeLikes { get; set; }
        public DbSet<Comment> Comments { get; set; }

        public DbSet<UserFollow> UserFollows { get; set; }

        public DbSet<CustomRecipeStep> CustomRecipeSteps { get; set; }

        public DbSet<CartItem> CartItems { get; set; }

        public DbSet<AIRequest> AIRequests { get; set; }
        public DbSet<RecipeStep> RecipeSteps { get; set; }

        public DbSet<Category> Categories { get; set; }
        public DbSet<CategoryTranslation> CategoryTranslations { get; set; }
        public DbSet<RecipeCategory> RecipeCategories { get; set; }


        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { 

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<RecipeTranslation>()
                .HasOne(r => r.Recipe)
                .WithMany(r => r.Translations)
                .HasForeignKey(r => r.RecipeId);

            builder.Entity<IngredientTranslation>()
                .HasOne(i => i.Ingredient)
                .WithMany(i => i.Translations)
                .HasForeignKey(i => i.IngredientId);

            builder.Entity<RecipeIngredient>()
                .HasOne(ri => ri.Recipe)
                .WithMany(r => r.RecipeIngredients)
                .HasForeignKey(ri => ri.RecipeId);

            builder.Entity<RecipeIngredient>()
                .HasOne(ri => ri.Ingredient)
                .WithMany(i => i.RecipeIngredients)
                .HasForeignKey(ri => ri.IngredientId);

            builder.Entity<RecipeStep>()
               .HasOne(s => s.Recipe)
               .WithMany(r => r.Steps)
               .HasForeignKey(s => s.RecipeId);

            builder.Entity<RecipeCategory>()
                .HasKey(rc => new { rc.RecipeId, rc.CategoryId });

            builder.Entity<RecipeCategory>()
                .HasOne(rc => rc.Recipe)
                .WithMany()
                .HasForeignKey(rc => rc.RecipeId);

            builder.Entity<RecipeCategory>()
                .HasOne(rc => rc.Category)
                .WithMany(c => c.RecipeCategories)
                .HasForeignKey(rc => rc.CategoryId);
        }
    }
}
