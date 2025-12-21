using Atmosync.Api.Interfaces.IServices;
using Atmosync.Api.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Atmosync.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DHTSensorController : ControllerBase
    {
        private readonly IDHTSensorService _iDHTSensorService;

        public DHTSensorController(IDHTSensorService iDHTSensorService)
        {
            _iDHTSensorService = iDHTSensorService;
        }

        // URL: GET https://localhost:7058/api/Iot/GetDHTData
        [HttpGet("GetDHTData")]
        public async Task<IActionResult> GetDHTSensorData()
        {
            var data = await _iDHTSensorService.GetDHTSensorDataAsync();
            return Ok(data);
        }

        
    }
}
