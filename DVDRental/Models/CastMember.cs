using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DVDRental.Models
{
    public class CastMember
    {
        [Required]
        [ForeignKey("DVDNumber")]
        public long DVDNumber { get; set; }
        [Required]
        [ForeignKey("ActorNumber")]
        public long ActorNumber { get; set; }   

    }
}
