using Atmosync.Shared.Models.DtoModels;
using Atmosync.Api.Models.Entities;

namespace Atmosync.Api.Interfaces.IRepositories
{
    public interface IDHTSensorRepository
    {
        Task<List<DHTSensor>> GetDHTSensorDataAsync();
        Task<long> CreateDHTSensorDataAsync(DHTSensorDto dHTSensorDto);

        Task<int> DeleteDHTSensorDataAsync(long dhtId);
    }
}
