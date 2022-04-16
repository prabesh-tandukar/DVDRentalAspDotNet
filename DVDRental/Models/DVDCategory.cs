using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DVDRental.Models
{
    public class DVDCategory
    {
        [Key]
        public long CategoryNumber { get; set; }
        public string CategoryDescription  { get; set; }
        public int AgeRestricted { get; set; }

    }
}
