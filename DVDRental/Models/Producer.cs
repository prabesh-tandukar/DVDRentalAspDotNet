using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DVDRental.Models
{
    public class Producer
    {
        [Key]
        public long ProducerNumber { get; set; }
        public string ProducerName { get; set; }
    }
}
