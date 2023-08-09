using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TECHWIZ.Models;
using TECHWIZ.Repository;

namespace TECHWIZ.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class APIBaseController<T> : ControllerBase where T : Base
    {
        //DI
        protected readonly IBaseRepository<T> _repository;
        public APIBaseController(IBaseRepository<T> repository)
        {
            _repository = repository;
        }

        //CRUD
        //CREATE

        [HttpPost]
        public async Task<IActionResult> Create(T entity)
        {
            var result = await _repository.CreateAsync(entity);
            if(result != null)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest("Error!");
            }
        }

        //UPDATE
        [HttpPut]
        public async Task<IActionResult> Update(T entity)
        {
            var result = await _repository.UpdateAsync(entity);
            if(result != null)
            {
                return Ok(result);

            }
            else
            {
                return BadRequest("Error!");
            }

        }

        //DELETE

        [HttpDelete] 
        public async Task<IActionResult> Delete(T entity)
        {
            var result = await _repository.DeleteAsync(entity);
            if(result != null)
            {
                return Ok(result);

            }
            else
            {
                return BadRequest("Error!");
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _repository.GetAllAsync();
            if(result != null)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest("Error!");
            }
        }

    }
}
