using Atmosync.Api.Models.Entities;

namespace Atmosync.Api.Interfaces.IServices
{
    public interface IMQ7SensorService
    {
        Task<List<MQ7Sensor>> GetMQ7SensorDataAsync();
    }
}
