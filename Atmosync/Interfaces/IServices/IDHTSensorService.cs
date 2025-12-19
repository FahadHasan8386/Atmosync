using Atmosync.Api.Models.Entities;

namespace Atmosync.Api.Interfaces.IServices
{
    public interface IDHTSensorService
    {
        Task<List<DHTSensor>> GetDHTSensorDataAsync();
    }
}
