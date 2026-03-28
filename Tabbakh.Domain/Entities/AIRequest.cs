using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabbakh.Domain.Entities
{
    public class AIRequest
    {
        public int Id { get; set; }

        public string UserId { get; set; }

        public string Prompt { get; set; }
        public string Response { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}