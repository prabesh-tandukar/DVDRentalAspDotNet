using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DVDRental.Models
{
    public class CastMember
    {
        [Key]
        public long DVDNumber { get; set; } 
       
        public long ActorNumber { get; set; }   

    }
}
