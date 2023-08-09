using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TECHWIZ.Models;
using TECHWIZ.Repository;

namespace TECHWIZ.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class APIMedicalDetailsController : APIBaseController<MedicalDetail>
    {
        public APIMedicalDetailsController(IBaseRepository<MedicalDetail> repository) : base(repository)
        {
        }
    }
}
