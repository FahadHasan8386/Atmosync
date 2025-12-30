using System.Net.Http.Json;
using Atmosync.Shared.Models.DtoModels;
using Atmosync.Shared.Models.ViewModels;

namespace Atmosync.Web.Service
{
    public class DHT22ApiService
    {
        private readonly HttpClient _httpClient;

        public DHT22ApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<DHTSensorViewModel>> GetDHTDataAsync()
        {
            var response = await _httpClient.GetFromJsonAsync<List<DHTSensorViewModel>>("DHTSensor/GetDHTData");
            return response ?? [];
        }

        public async Task AddDHTAsync(DHTSensorDto dHTSensordepositDto)
        {
            var response = await _httpClient.PostAsJsonAsync("DHTSensor/CreateDHTData", dHTSensordepositDto);
            response.EnsureSuccessStatusCode();
        }

        public async Task DeleteDHTAsync(long dhtId)
        {
            var response = await _httpClient.DeleteAsync($"DHTSensor/DeleteDHTData/{dhtId}");
            response.EnsureSuccessStatusCode();
        }
    }
}
