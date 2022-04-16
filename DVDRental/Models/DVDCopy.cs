using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DVDRental.Models
{
    public class DVDCopy
    {
        [Key]
        public long CopyNumber { get; set; }
        public long DVDNumber { get; set; }
        public DateOnly DatePurchased { get; set; }
    }
}
