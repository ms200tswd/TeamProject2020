using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamProject.Models
{
    public class Tour
    {
        public int TourId { get; set; }
        public string Destination { get; set; }
        public int Price { get; set; }
        public DateTime Departure { get; set; }
        public DateTime Arrival { get; set; }

        public virtual ICollection<Summary> Summaries { get; set; }


    }
}
