using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DVDRental.Models
{
    public class Loan
    {
        [Key]
        public long LoanNumber { get; set; }
        public long LoanTypeNumber { get; set; }
        public long CopyNumber { get; set; }
        public long MemberNumber { get; set; }
        public DateTime DateOut { get; set; }
        public DateTime DateDue { get; set; }
        public DateTime DateReturned { get; set; }

    }
}
