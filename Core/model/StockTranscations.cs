using System;
using System.ComponentModel.DataAnnotations;

namespace pfs.Core.model
{
    public class StockTranscations
    {
        public int Id { get; set; }
        [Required]
        [StringLength(10)]
        public string  StockCode { get; set; }
        [Required]
        [StringLength(255)]
        public string  Description { get; set; }
        [Required]
        public decimal BuyPrice { get; set; }
        public decimal SellPrice { get; set; }
        [Required]
        public int Lots { get; set; }
        [Required]
        public bool BuyAction { get; set; }
        [Required]
        public decimal Value { get; set; }
        [Required]
        public decimal Profit { get; set; }
        [Required]
        public DateTime ActionDate { get; set; }
        [Required]
        public DateTime LastModifiedDate { get; set; }
        [Required]
        public string LastModifiedBy { get; set; }
    }
}