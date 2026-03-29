using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabbakh.Domain.Entities
{
    public class Category
    {
        public int Id { get; set; }

        public ICollection<CategoryTranslation> Translations { get; set; }
        public ICollection<RecipeCategory> RecipeCategories { get; set; }
    }
}
