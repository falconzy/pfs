using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace pfs.Core.model
{
    public class Currency
    {
        public int Id { get; set; }
        [Required]
        [StringLength(10)]
        public string  CurrencyName { get; set; }
        [Required]
        [StringLength(255)]
        public string  Description { get; set; }
        [Required]
        public DateTime LastUpdateDate { get; set; }
        [Required]
        public DateTime LastModifiedBy { get; set; }
    }
}