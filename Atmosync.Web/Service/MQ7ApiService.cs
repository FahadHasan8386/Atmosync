using System.Net.Http.Json;
using Atmosync.Shared.Models.ViewModels;

namespace Atmosync.Web.Service
{
    public class MQ7ApiService
    {
        private readonly HttpClient _httpClient;

        public MQ7ApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<MQ7SensorViewModel>> GetMQ7DataAsync()
        {
            var response = await _httpClient.GetFromJsonAsync<List<MQ7SensorViewModel>>("MQ7Sensor/GetMQ7Data");
            return response ?? [];
        }
    }
}
