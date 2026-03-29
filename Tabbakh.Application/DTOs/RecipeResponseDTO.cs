using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabbakh.Application.DTOs
{
    public class RecipeResponseDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int CookingTimeMinutes { get; set; }
        public string Difficulty { get; set; }

        public List<string> Ingredients { get; set; }
    }
}
