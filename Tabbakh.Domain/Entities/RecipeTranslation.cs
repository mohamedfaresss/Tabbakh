using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabbakh.Domain.Entities
{
    public class RecipeTranslation
    {
        public int Id { get; set; }

        public int RecipeId { get; set; }
        public string Language { get; set; } // ar / en

        public string Name { get; set; }
        public string Description { get; set; }

        public Recipe Recipe { get; set; }
    }
}
