using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NW2.Models
{
    [Table("Visiting")]
    public class Visiting
    {
        [Key]
        public int VisitingID { get; set; }
        public string? VisitingName { get; set; }

        //public bool? IsActive { get; set; }

        public string? VisitingRN { get; set; }
        public string? VisitingCT { get; set; }
        public string? VisitingAddress { get; set; }
        public string? Day { get; set; }
        public string? Time { get; set; }

    }
}
