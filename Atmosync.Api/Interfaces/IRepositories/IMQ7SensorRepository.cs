using Atmosync.Api.Models.Entities;

namespace Atmosync.Api.Interfaces.IRepositories
{
    public interface IMQ7SensorRepository
    {
        Task<List<MQ7Sensor>> GetMQ7SensorDataAsync();
    }
}
