using Atmosync.Shared.Models.DtoModels;
using Atmosync.Api.Models.Entities;

namespace Atmosync.Api.Interfaces.IServices
{
    public interface IMQ7SensorService
    {
        Task<List<MQ7Sensor>> GetMQ7SensorDataAsync();
        Task<long> CreateMQ7SensorDataAsync(MQ7SensorDto mQ7SensorDto);
    }
}
