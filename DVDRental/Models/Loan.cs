using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DVDRental.Models
{
    public class Loan
    {
        [Key]
        public long LoanNumber { get; set; }
        [ForeignKey("LoanTypeNumber")]
        public long LoanTypeNumber { get; set; }
        [ForeignKey("CopyNumber")]
        public long CopyNumber { get; set; }
        [ForeignKey("MemberNumber")]
        public long MemberNumber { get; set; }
        public DateTime DateOut { get; set; }
        public DateTime DateDue { get; set; }
        public DateTime DateReturned { get; set; }

    }
}
