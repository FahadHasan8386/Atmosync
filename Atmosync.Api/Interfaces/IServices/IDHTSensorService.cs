using Atmosync.Shared.Models.DtoModels;
using Atmosync.Api.Models.Entities;

namespace Atmosync.Api.Interfaces.IServices
{
    public interface IDHTSensorService
    {
        Task<List<DHTSensor>> GetDHTSensorDataAsync();
        Task<long> CreateDHTSensorDataAsync(DHTSensorDto dHTSensorDto);
    }
}
