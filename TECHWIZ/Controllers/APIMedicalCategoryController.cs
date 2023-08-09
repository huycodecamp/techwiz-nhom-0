using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TECHWIZ.Models;
using TECHWIZ.Repository;

namespace TECHWIZ.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class APIMedicalCategoryController : APIBaseController<MedicalCategory>
    {
        private readonly IMedicalCategoryRepository _medicalCategoryRepository;
        public APIMedicalCategoryController(IBaseRepository<MedicalCategory> repository, IMedicalCategoryRepository medicalCategoryRepository) : base(repository)
        {
            _medicalCategoryRepository = medicalCategoryRepository;
        }
        [HttpGet("GetByParentId/{parentId}")]
        public async Task<IActionResult> GetByParentIdAsync(int parentId)
        {
            var result = await _medicalCategoryRepository.GetByParentIdAsync(parentId);
            return Ok(result);
        }
    }
}
