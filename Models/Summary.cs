using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamProject.Models
{
    public class Summary
    {
        public int TourId { get; set; }
        public int UserId { get; set; }

        public virtual Tour Tour { get; set; }
        public virtual User User { get; set; }
    }
}
