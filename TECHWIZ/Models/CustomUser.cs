using Microsoft.AspNetCore.Identity;

namespace TECHWIZ.Models
{
    public class CustomUser : IdentityUser
    {
        public bool? Gender { get; set; }
        public string? Fullname { get; set; }

        public string? Address { get; set; }
        //Them o ben duoi 
    }
}
