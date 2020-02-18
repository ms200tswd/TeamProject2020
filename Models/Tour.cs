using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TeamProject.Models
{
    public class Tour
    {
        public int TourId { get; set; }
        [Required]
        [StringLength(256)]
        public string Destination { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        public int Price { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime Departure { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime Arrival { get; set; }

        public virtual ICollection<Summary> Summaries { get; set; }


    }
}
