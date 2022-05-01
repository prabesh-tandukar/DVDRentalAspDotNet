using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DVDRental.Models
{
    public class DVDTitle
    {
        [Key]
        public long DVDNumber { get; set; }
        public long CategoryNumber { get; set; }    
        public long StudioNumber    { get; set; }
        public long ProducerNumber { get; set; }
        public string DVDtitle { get; set; }
        public DateTime DateReleased { get; set; }
        public string StandardCharge { get; set; }
        public string PenaltyCharge { get; set; }

    }
}
