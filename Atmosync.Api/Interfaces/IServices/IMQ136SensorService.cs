using Atmosync.Api.Models.Entities;
using Atmosync.Shared.Models.DtoModels;

namespace Atmosync.Api.Interfaces.IServices
{
    public interface IMQ136SensorService
    {
        Task<List<MQ136Sensor>> GetMQ136SensorDataAsync();
        Task<long> CreateMQ136SensorDataAsync(MQ136SensorDto mQ136SensorDto);
    }
}
