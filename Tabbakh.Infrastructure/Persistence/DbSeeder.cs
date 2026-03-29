using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tabbakh.Domain.Entities;

namespace Tabbakh.Infrastructure.Persistence
{
    public static class DbSeeder
    {
        public static void Seed(AppDbContext context)
        {
            if (context.Recipes.Any()) return;

            var ingredients = new List<Ingredient>
        {
            new Ingredient
            {
                Translations = new List<IngredientTranslation>
                {
                    new IngredientTranslation { Language = "ar", Name = "رز" },
                    new IngredientTranslation { Language = "en", Name = "Rice" }
                }
            },
            new Ingredient
            {
                Translations = new List<IngredientTranslation>
                {
                    new IngredientTranslation { Language = "ar", Name = "فراخ" },
                    new IngredientTranslation { Language = "en", Name = "Chicken" }
                }
            },
            new Ingredient
            {
                Translations = new List<IngredientTranslation>
                {
                    new IngredientTranslation { Language = "ar", Name = "بصل" },
                    new IngredientTranslation { Language = "en", Name = "Onion" }
                }
            }
        };

            context.Ingredients.AddRange(ingredients);
            context.SaveChanges();

            var recipes = new List<Recipe>();

            for (int i = 1; i <= 150; i++)
            {
                var recipe = new Recipe
                {
                    CookingTimeMinutes = 30,
                    Difficulty = "Easy",
                    CreatedByUserId = "seed-user",
                    IsApproved = true,
                    CreatedAt = DateTime.UtcNow,

                    Translations = new List<RecipeTranslation>
                {
                    new RecipeTranslation
                    {
                        Language = "ar",
                        Name = $"وجبة رقم {i}",
                        Description = "وصفة لذيذة"
                    },
                    new RecipeTranslation
                    {
                        Language = "en",
                        Name = $"Recipe {i}",
                        Description = "Delicious recipe"
                    }
                },

                    RecipeIngredients = new List<RecipeIngredient>
                {
                    new RecipeIngredient
                    {
                        IngredientId = ingredients[0].Id,
                        Quantity = 1,
                        Unit = "cup"
                    }
                }
                };

                recipes.Add(recipe);
            }

            context.Recipes.AddRange(recipes);
            context.SaveChanges();
        }
    }
}
