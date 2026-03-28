using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabbakh.Domain.Entities
{
    public class RecipeLike
    {
        public int Id { get; set; }

        public string UserId { get; set; }
        public int RecipeId { get; set; }

        public Recipe Recipe { get; set; }
    }
}
