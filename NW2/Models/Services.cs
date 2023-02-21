using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NW2.Models
{
    [Table("Services")]
    public class Services
    {
        [Key]
        public int ServicesID { get; set; }
        public string? ServicesName { get; set; }
        public string? ServicesDetail { get; set; }
        public string? ServicesIMG { get; set; }

        public int? ServicesOrder { get; set; }

    }
}
