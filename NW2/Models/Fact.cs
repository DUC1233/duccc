using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NW2.Models
{
    [Table("Fact")]
    public class Fact
    {
        [Key]
        public int FactID { get; set; }
        public string? FactName { get; set; }

        //public bool? IsActive { get; set; }

        public string? Amount { get; set; }
        public string? Icon { get; set; }

    }
}
