using Atmosync.Api.Models.Entities;

namespace Atmosync.Api.Interfaces.IRepositories
{
    public interface IDHTSensorRepository
    {
        Task<List<DHTSensor>> GetDHTSensorDataAsync();
    }
}
