using System.ComponentModel.DataAnnotations.Schema;

namespace TECHWIZ.Models
{
    public class MedicalCategory : Base
    {
        public string? Name { get; set; }
        public int? ParentId { get; set; }

        [ForeignKey("ParentId")]
        public MedicalCategory? GetParent { get; set; }
    }
}
