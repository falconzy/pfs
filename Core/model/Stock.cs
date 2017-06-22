using System;
using System.ComponentModel.DataAnnotations;

namespace pfs.Core.model
{
    public class Stock
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
        public decimal CurrentPrice { get; set; }
        [Required]
        public int Lots { get; set; }
        [Required]
        public decimal BuyValue { get; set; }
        public decimal CurrentValue { get; set; }
        [Required]
        public DateTime PurchaseDate { get; set; }
        [Required]
        public DateTime LastModifiedDate { get; set; }
        [Required]
        public string LastModifiedBy { get; set; }
    }
}