using System;
using System.ComponentModel.DataAnnotations;

namespace pfs.Core.model
{
    public class Transactions
    {
        public int Id { get; set; }
        public string  Description { get; set; }
        [Required]
        public decimal Amount { get; set; }
        [Required]
        public int TransactionTypeId { get; set; }
        public virtual TransactionType TransactionType { get; set; } 
        [Required]
        public int SpendingTypeId { get; set; }
        public virtual SpendingType SpendingType { get; set; } 
        [Required]
        public int  Month { get; set; }
        [Required]
        public int  Year { get; set; }
        [Required]
        public DateTime UpdateDate { get; set; }
        [Required]
        public string ModifiedBy { get; set; }

    }
}