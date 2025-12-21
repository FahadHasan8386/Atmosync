using Atmosync.Api.Interfaces.IServices;
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
    }
}
