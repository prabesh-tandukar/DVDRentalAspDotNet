using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DVDRental.Models
{
    public class Actor
    {
       [Key]
        public long ActorNumber { get; set; }
        public string ActorSurname { get; set; }
        public string ActorFirstName { get; set; }
     
    }
}
