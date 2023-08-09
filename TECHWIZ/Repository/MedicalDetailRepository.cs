using Microsoft.AspNetCore.Identity;
using TECHWIZ.Data;
using TECHWIZ.Models;

namespace TECHWIZ.Repository
{

    public interface IMedicalDetailRepository : IBaseRepository<MedicalDetail>
    {

    }
    public class MedicalDetailRepository : BaseRepository<MedicalDetail>, IMedicalDetailRepository
    {
        public MedicalDetailRepository(ApplicationDbContext context, UserManager<CustomUser> userManager, IHttpContextAccessor contextAccessor) : base(context, userManager, contextAccessor)
        {
        }
    }
}
