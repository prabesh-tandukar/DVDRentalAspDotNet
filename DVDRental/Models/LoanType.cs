using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DVDRental.Models
{
    public class LoanType
    {
        [Key]
        public long LoanTypeNumber { get; set; }
        public string LoanTypes { get; set; }
        public string LoanDuration { get; set; }
    }
}
