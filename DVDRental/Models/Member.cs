using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DVDRental.Models
{
    public class Member
    {
        [Key]
        public long MemberNumber { get; set; }
        public long MembershipCategoryNumber { get; set; }
        public string MemberLastName { get; set; }
        public string MemberFirstName { get; set; }
        public string MemberAddress { get; set; }
        public DateTime MemberDateOfBirth { get; set; }
    }
}
