using Tabbakh.Domain.Entities;

public class Recipe
{
    public int Id { get; set; }

    public string? ImageUrl { get; set; }
    public string? VideoUrl { get; set; } // 🔥 جديد

    public int CookingTimeMinutes { get; set; }
    public string Difficulty { get; set; }

    public int Views { get; set; } = 0; // 🔥 جديد

    public string CreatedByUserId { get; set; }

    public bool IsApproved { get; set; } = false;
    public bool IsDeleted { get; set; } = false;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    // Relations
    public ICollection<RecipeTranslation> Translations { get; set; }
    public ICollection<RecipeIngredient> RecipeIngredients { get; set; }
    public ICollection<RecipeStep> Steps { get; set; } // 🔥 جديد
}