using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabbakh.Domain.Entities
{
    public class UserFollow
    {
        public int Id { get; set; }

        public string FollowerId { get; set; }
        public string FollowingId { get; set; }
    }
}
