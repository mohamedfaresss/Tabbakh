using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabbakh.Domain.Entities
{
    public class Ingredient
    {
        public int Id { get; set; }

        public ICollection<IngredientTranslation> Translations { get; set; }
        public ICollection<RecipeIngredient> RecipeIngredients { get; set; }
    }
}
