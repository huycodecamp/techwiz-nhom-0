using System.ComponentModel.DataAnnotations.Schema;

namespace TECHWIZ.Models
{
    public class PrescriptionDetail : Base
    {
        public int? PrescriptionId { get; set; }
        public int? MedicalDetailId { get; set; }
        public string? Description { get; set; }

        [ForeignKey("PrescriptionId")]
        public Prescription? GetPrescription { get; set; }

        [ForeignKey("MedicalDetailId")]
        public MedicalDetail? GetMedicalDetailId { get; set; }
    }
}
