using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DVDRental.Models
{
    public class MembershipCategory
    {
        [Key]
        public long MembershipCategoryNumber { get; set; }
        public string MembershipCategoryDescription { get; set; }
        public string MembershipCategoryTotalLoans { get; set; }
    }
}
