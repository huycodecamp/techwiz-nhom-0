using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace TECHWIZ.Models
{
    public class MedicalDetail : Base
    {
        public string? Name { get; set; }
        public decimal? Quantity { get; set; }
        public string? Unit { get; set; }
        public string? Warning { get; set; }
        public string? Description { get; set; }

        public int? MedicalCategoryId { get; set; }


        [ForeignKey("MedicalCategoryId")]
        public MedicalCategory? GetMedicalCategory { get; set; }

    }
}
