using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NW2.Models
{
    [Table("Animals")]
    public class Animals
    {
        [Key]
        public int AnimalsID { get; set; }
        public string? AnimalsName { get; set; }
        public string? AnimalsRN { get; set; }
        public string? AnimalsIMG { get; set; }


    }
}
