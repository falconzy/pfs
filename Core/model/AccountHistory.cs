using System;
using System.ComponentModel.DataAnnotations;

namespace pfs.Core.model
{
    public class AccountHistory
    {
        public int Id { get; set; }
        [Required]
        [StringLength(10)]
        public string  AccountName { get; set; }
        [Required]
        [StringLength(255)]
        public string  Description { get; set; }
        [Required]
        public decimal Amount { get; set; }
        [Required]
        public string Currency { get; set; }
        [Required]
        public DateTime UpdateDate { get; set; }
        [Required]
        public DateTime ModifiedBy { get; set; }
    }
}