using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabbakh.Application.DTOs
{
    public class CreateRecipeDTO
    {
        public string NameAr { get; set; }
        public string NameEn { get; set; }

        public string DescriptionAr { get; set; }
        public string DescriptionEn { get; set; }

        public int CookingTimeMinutes { get; set; }
        public string Difficulty { get; set; }

        public List<RecipeIngredientDTO> Ingredients { get; set; }
    }
}