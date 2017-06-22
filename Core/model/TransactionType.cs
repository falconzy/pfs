using System.ComponentModel.DataAnnotations;

namespace pfs.Core.model
{
    public class TransactionType
    {
        public int Id { get; set; }
        [Required]
        [StringLength(10)]
        public string Name { get; set; }
    }
}