using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DVDRental.Models
{
    public class Studio
    {
        [Key]
        public long StudioNumber { get; set; }
        public string StudioName { get; set; }
    }
}
