using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace pfs.Controllers.Resources
{
    public class StockResource
    {
        public int Id { get; set; }
        [Required]
        [StringLength(10)]
        public string  StockCode { get; set; }
        [Required]
        [StringLength(255)]
        public string  Description { get; set; }
        [Required]
        public string Acion { get; set; } //(1-BUY|2-SELL|3-UPDATE)
        [Required]
        public decimal Price { get; set; }
        [Required]
        public int Lots { get; set; }
        [Required]
        public decimal Value { get; set; }      
    }
}