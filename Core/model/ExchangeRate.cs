using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace pfs.Core.model
{
    public class ExchangeRate
    {
        public int Id { get; set; }
        [Required]
        [StringLength(10)]
        [ForeignKeyAttribute("LocalCurrency"), Column(Order = 0)]
        public int  LocalCurrencyId { get; set; }
        [Required]
        [StringLength(10)]
        [ForeignKeyAttribute("ForeignCurrency"), Column(Order = 1)]
        public int  ForeignCurrencyId { get; set; }
        public virtual Currency LocalCurrency { get; set; } 
        public virtual Currency ForeignCurrency { get; set; } 
        [Required]
        public decimal Rate { get; set; }
        [Required]
        public int  Month { get; set; }
        [Required]
        public int  Year { get; set; }
        [Required]
        public DateTime LastUpdateDate { get; set; }
        [Required]
        public string LastModifiedBy { get; set; }
    }
}