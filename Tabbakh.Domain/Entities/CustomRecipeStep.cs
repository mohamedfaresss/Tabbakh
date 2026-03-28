using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabbakh.Domain.Entities
{
    public class CustomRecipeStep
    {
        public int Id { get; set; }

        public int RecipeId { get; set; }
        public string UserId { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }

        public bool IsApproved { get; set; } = false;

        public Recipe Recipe { get; set; }
    }
}