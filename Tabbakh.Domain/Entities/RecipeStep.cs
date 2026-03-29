using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabbakh.Domain.Entities
{
    public class RecipeStep
    {
        public int Id { get; set; }

        public int RecipeId { get; set; }

        public int Order { get; set; }

        public string DescriptionAr { get; set; }
        public string DescriptionEn { get; set; }

        public Recipe Recipe { get; set; }
    }
}
