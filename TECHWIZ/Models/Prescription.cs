using System.ComponentModel.DataAnnotations.Schema;

namespace TECHWIZ.Models
{
    public class Prescription : Base
    {
        public string? Code { get; set; }
        public string? PatientId { get; set; }

        [ForeignKey("PatientId")]
        public CustomUser? GetPatient { get; set; }
    }
}
