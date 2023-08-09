using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TECHWIZ.Data;
using TECHWIZ.Models;

namespace TECHWIZ.Repository
{
    public interface IMedicalCategoryRepository : IBaseRepository<MedicalCategory>
    {
        Task<List<MedicalCategory>> GetByParentIdAsync(int parentId);
    }
    public class MedicalCategoryRepository : BaseRepository<MedicalCategory>, IMedicalCategoryRepository
    {
        public MedicalCategoryRepository(ApplicationDbContext context, UserManager<CustomUser> userManager, IHttpContextAccessor contextAccessor) : base(context, userManager, contextAccessor)
        {
        }
        
        public async Task<List<MedicalCategory>> GetByParentIdAsync(int parentId)
        {
            var result = await _dbSet.Where(r => r.ParentId == parentId).ToListAsync();
            return result;
            

        }
    }
}
