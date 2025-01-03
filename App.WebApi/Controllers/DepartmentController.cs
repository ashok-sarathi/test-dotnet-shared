using App.Business.Models;
using App.Business.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController(IDepartmentService service) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get([FromQuery] DepartmentQueryModel query)
        {
            return Ok(service.Get(query));
        }

        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            return Ok(service.GetById(id));
        }

        [HttpPost]
        public IActionResult Post([FromBody] DepartmentModel model)
        {
            return Ok(service.Create(model));
        }
    }
}
