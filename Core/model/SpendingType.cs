using System.ComponentModel.DataAnnotations;

namespace pfs.Core.model
{
    public class SpendingType
    {
        public int Id { get; set; }
        [Required]
        [StringLength(10)]
        public string  Name { get; set; }
    }
}