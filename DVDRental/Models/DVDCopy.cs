using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DVDRental.Models
{
    public class DVDCopy
    {
        [Key]
        public long CopyNumber { get; set; }
        [ForeignKey("DVDNumber")]
        public long DVDNumber { get; set; }
        public DateTime DatePurchased { get; set; }
    }
}
