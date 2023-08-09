using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TECHWIZ.Models
{
    public class Base
    {
        [Key]
        public int Id { get; set; }

        public string? CreatedUser { get; set; }
        public DateTime? CreatedTime { get; set; }

        public string? UpdatedUser { get; set; }
        public DateTime? UpdatedTime { get; set; }

        public bool? IsDeleted { get; set; }

        public string? DeletedUser { get; set; }

        public DateTime? DeletedTime { get; set; }


        [ForeignKey("CreatedUser")]
        public CustomUser? GetCreatedUser { get; set; }
    }
}
