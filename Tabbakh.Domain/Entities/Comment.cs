using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabbakh.Domain.Entities
{
    public class Comment
    {
        public int Id { get; set; }

        public string UserId { get; set; }
        public int RecipeId { get; set; }

        public string Content { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public Recipe Recipe { get; set; }
    }
}
