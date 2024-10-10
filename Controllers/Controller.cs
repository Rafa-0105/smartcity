using Microsoft.AspNetCore.Mvc;
using RestFul_api.Models;
using RestFul_api.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RestFul_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DisastersController : ControllerBase
    {
        private readonly IDisasterService _disasterService;

        public DisastersController(IDisasterService disasterService)
        {
            _disasterService = disasterService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Disaster>>> GetAllDisasters()
        {
            var disasters = await _disasterService.GetAllDisastersAsync();
            return Ok(disasters);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Disaster>> GetDisasterById(int id)
        {
            var disaster = await _disasterService.GetDisasterByIdAsync(id);
            if (disaster == null)
            {
                return NotFound();
            }
            return Ok(disaster);
        }

        [HttpPost]
        public async Task<ActionResult<Disaster>> AddDisaster(Disaster disaster)
        {
            var newDisaster = await _disasterService.AddDisasterAsync(disaster);
            return CreatedAtAction(nameof(GetDisasterById), new { id = newDisaster.Id }, newDisaster);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateDisaster(int id, Disaster disaster)
        {
            if (id != disaster.Id)
            {
                return BadRequest();
            }

            await _disasterService.UpdateDisasterAsync(disaster);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDisaster(int id)
        {
            var disaster = await _disasterService.GetDisasterByIdAsync(id);
            if (disaster == null)
            {
                return NotFound();
            }

            await _disasterService.DeleteDisasterAsync(id);
            return NoContent();
        }
    }
}