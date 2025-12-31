using System.Net.Http.Json;
using Atmosync.Shared;
using Atmosync.Shared.Models.DtoModels;
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

        public async Task<HttpResponseMessage> DeleteMQ7Async(long mQ7Id)
        {
            return await _httpClient.DeleteAsync($"MQ7Sensor/DeleteMQ7Data/{mQ7Id}");
     
        }
    }
}
