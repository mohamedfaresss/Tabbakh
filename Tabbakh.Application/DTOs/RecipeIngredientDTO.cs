using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabbakh.Application.DTOs
{
    public class RecipeIngredientDTO
    {
        public int IngredientId { get; set; }
        public double Quantity { get; set; }
        public string Unit { get; set; }
    }
}
