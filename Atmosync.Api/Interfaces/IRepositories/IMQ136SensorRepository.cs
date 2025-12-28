using Atmosync.Api.Models.Entities;
using Atmosync.Shared.Models.DtoModels;

namespace Atmosync.Api.Interfaces.IRepositories
{
    public interface IMQ136SensorRepository
    {
        Task<List<MQ136Sensor>> GetMQ136SensorDataAsync();
        Task<long> CreateMQ136SensorDataAsync(MQ136SensorDto mQ136SensorDto);
    }
}
