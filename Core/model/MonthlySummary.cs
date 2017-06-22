using System;
using System.ComponentModel.DataAnnotations;

namespace pfs.Core.model
{
    public class MonthlySummary
    {
        public int Id { get; set; }
        [Required]
        public decimal CashFlow { get; set; }
        [Required]
        public decimal InvestmentAmount { get; set; }
        [Required]
        public decimal LongTermFixAmount { get; set; }
        [Required]
        public decimal LivingCost { get; set; }
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