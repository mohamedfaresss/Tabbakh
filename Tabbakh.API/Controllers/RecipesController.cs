using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using Tabbakh.Application.DTOs;
using Tabbakh.Domain.Entities;
using Tabbakh.Infrastructure.Persistence;

[ApiController]
[Route("api/[controller]")]
public class RecipesController : ControllerBase
{
    private readonly AppDbContext _context;

    public RecipesController(AppDbContext context)
    {
        _context = context;
    }

    // ✅ Create Recipe
    [Authorize]
    [HttpPost]
    public async Task<IActionResult> Create(CreateRecipeDTO dto)
    {
        var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

        var recipe = new Recipe
        {
            CreatedByUserId = userId,
            CookingTimeMinutes = dto.CookingTimeMinutes,
            Difficulty = dto.Difficulty,
            IsApproved = false
        };

        // Translations
        recipe.Translations = new List<RecipeTranslation>
        {
            new RecipeTranslation
            {
                Language = "ar",
                Name = dto.NameAr,
                Description = dto.DescriptionAr
            },
            new RecipeTranslation
            {
                Language = "en",
                Name = dto.NameEn,
                Description = dto.DescriptionEn
            }
        };

        // Ingredients
        recipe.RecipeIngredients = dto.Ingredients.Select(i => new RecipeIngredient
        {
            IngredientId = i.IngredientId,
            Quantity = i.Quantity,
            Unit = i.Unit
        }).ToList();

        _context.Recipes.Add(recipe);
        await _context.SaveChangesAsync();

        return Ok("Recipe created successfully");
    }

    // ✅ Get All Recipes
    [HttpGet]
    public async Task<IActionResult> GetAll(string lang = "en", int page = 1, int pageSize = 10)
    {
        var recipes = await _context.Recipes
            .Include(r => r.Translations)
            .Include(r => r.RecipeIngredients)
                .ThenInclude(ri => ri.Ingredient)
                    .ThenInclude(i => i.Translations)
            .Where(r => r.IsApproved && !r.IsDeleted)
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();

        var result = recipes.Select(r => new RecipeResponseDTO
        {
            Id = r.Id,
            Name = r.Translations.FirstOrDefault(t => t.Language == lang)?.Name,
            Description = r.Translations.FirstOrDefault(t => t.Language == lang)?.Description,
            CookingTimeMinutes = r.CookingTimeMinutes,
            Difficulty = r.Difficulty,
            Ingredients = r.RecipeIngredients
                .Select(i => i.Ingredient.Translations
                    .FirstOrDefault(t => t.Language == lang)?.Name)
                .ToList()
        });

        return Ok(result);
    }
}