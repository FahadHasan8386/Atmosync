using Atmosync.Api.Interfaces.IServices;
using Atmosync.Api.Services;
using Atmosync.Shared.Models.DtoModels;
using Microsoft.AspNetCore.Mvc;

namespace Atmosync.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MQ136SensorController : ControllerBase
    {
        private readonly IMQ136SensorService _iMQ136SensorService;

        public MQ136SensorController(IMQ136SensorService iMQ136SensorService)
        {
            _iMQ136SensorService = iMQ136SensorService;
        }

        // URL: GET https://localhost:7058/api/Iot/GetMQ7Data
        [HttpGet("GetMQ136Data")]
        public async Task<IActionResult> GetMQ136SensorData()
        {
            var data = await _iMQ136SensorService.GetMQ136SensorDataAsync();
            return Ok(data);
        }

        [HttpPost("CreateMQ136Data")]
        public async Task<IActionResult> CreateMQ136SensorData([FromBody] MQ136SensorDto mQ136SensorDto)
        {
            if (mQ136SensorDto == null) return BadRequest("Invalid data");

            try
            {
                var id = await _iMQ136SensorService.CreateMQ136SensorDataAsync(mQ136SensorDto);
                return Ok(new { Message = "Data saved successfully", Id = id });
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpDelete("DeleteMQ136Data/{id}")]
        public async Task<IActionResult> DeleteMQ136Async(long id)
        {
            if (id <= 0)
                return BadRequest("Invalid MQ136 ID.");

            var result = await _iMQ136SensorService.DeleteMQ136Async(id);

            if (result == 0)
                return NotFound("MQ136 data not found.");

            return Ok("MQ136 data deleted successfully.");
        }
    }
}