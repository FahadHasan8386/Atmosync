using Atmosync.Api.Interfaces.IServices;
using Atmosync.Shared.Models.DtoModels;
using Atmosync.Api.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Atmosync.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MQ7SensorController : ControllerBase
    {
        private readonly IMQ7SensorService _iMQ7SensorService;

        public MQ7SensorController(IMQ7SensorService iMQ7SensorService)
        {
            _iMQ7SensorService = iMQ7SensorService;
        }

        // URL: GET https://localhost:7058/api/Iot/GetMQ7Data
        [HttpGet("GetMQ7Data")]
        public async Task<IActionResult> GetMQ7SensorData()
        {
            var data = await _iMQ7SensorService.GetMQ7SensorDataAsync();
            return Ok(data);
        }

        [HttpPost("CreateMQ7Data")]
        public async Task<IActionResult> CreateMQ7SensorData([FromBody] MQ7SensorDto mQ7SensorDto)
        {
            if (mQ7SensorDto == null) return BadRequest("Invalid data");

            try
            {
                var id = await _iMQ7SensorService.CreateMQ7SensorAsync(mQ7SensorDto);
                return Ok(new { Message = "Data saved successfully", Id = id });
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpDelete("DeleteMQ7Data/{id}")]
        public async Task<IActionResult> DeleteMQ7Async(long id)
        {
            if (id <= 0)
                return BadRequest("Invalid MQ7 ID.");

            var result = await _iMQ7SensorService.DeleteMQ7Async(id);

            if (result == 0)
                return NotFound("MQ7 data not found.");

            return Ok("MQ7 data deleted successfully.");
        }
    }
}
