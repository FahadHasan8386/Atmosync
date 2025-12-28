using Atmosync.Shared.Models.DtoModels;
using Atmosync.Api.Models.Entities;

namespace Atmosync.Api.Interfaces.IRepositories
{
    public interface IMQ7SensorRepository
    {
        Task<List<MQ7Sensor>> GetMQ7SensorDataAsync();
        Task<long> CreateMQ7SensorDataAsync(MQ7SensorDto mQ7SensorDto);
        Task<int> DeleteMQ7SensorDataAsync(long mQ7Id);
    }
}
