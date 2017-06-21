using System;
using System.ComponentModel.DataAnnotations;

namespace pfs.Core.model
{
    public class ExchangeRate
    {
        public int Id { get; set; }
        [Required]
        [StringLength(10)]
        public int  LocalCurrencyFK { get; set; }
        [Required]
        [StringLength(10)]
        public int  foreignCurrencyFK { get; set; }
        [Required]
        public decimal Rate { get; set; }
        [Required]
        public DateTime LastUpdateDate { get; set; }
        [Required]
        public DateTime LastModifiedBy { get; set; }
    }
}