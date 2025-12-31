using System.Net.Http.Json;
using Atmosync.Shared;
using Atmosync.Shared.Models.DtoModels;
using Atmosync.Shared.Models.ViewModels;

namespace Atmosync.Web.Service
{
    public class MQ136ApiService
    {
        private readonly HttpClient _httpClient;

        public MQ136ApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<MQ136SensorViewModel>> GetMQ136DataAsync()
        {
            var response = await _httpClient.GetFromJsonAsync<List<MQ136SensorViewModel>>("MQ136Sensor/GetMQ136Data");
            return response ?? [];
        }

        public async Task<HttpResponseMessage> DeleteMQ136Async(long mQ136Id)
        {
            return await _httpClient.DeleteAsync($"MQ136Sensor/DeleteMQ136Data/{mQ136Id}");
        }
    }
}
