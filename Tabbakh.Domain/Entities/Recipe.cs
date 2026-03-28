using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabbakh.Domain.Entities
{
    public class Recipe
    {
        public int Id { get; set; }

        public string? ImageUrl { get; set; }
        public int CookingTimeMinutes { get; set; }
        public string Difficulty { get; set; }

        public string CreatedByUserId { get; set; }

        public bool IsApproved { get; set; } = false;
        public bool IsDeleted { get; set; } = false;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Relations
        public ICollection<RecipeTranslation> Translations { get; set; }
        public ICollection<RecipeIngredient> RecipeIngredients { get; set; }
        public ICollection<RecipeLike> Likes { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
