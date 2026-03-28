using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabbakh.Domain.Entities
{
    public class CartItem
    {
        public int Id { get; set; }

        public string UserId { get; set; }
        public int IngredientId { get; set; }

        public double Quantity { get; set; }

        public Ingredient Ingredient { get; set; }
    }
}