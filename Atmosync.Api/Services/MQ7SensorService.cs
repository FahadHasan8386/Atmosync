using Atmosync.Api.Interfaces.IRepositories;
using Atmosync.Api.Interfaces.IServices;
using Atmosync.Shared.Models.DtoModels;
using Atmosync.Api.Models.Entities;
using Atmosync.Api.Repository;

namespace Atmosync.Api.Services
{
    public class MQ7SensorService : IMQ7SensorService
    {
        private readonly IMQ7SensorRepository _iMQ7SensorRepository;

        public MQ7SensorService(IMQ7SensorRepository iMQ7SensorRepository) => _iMQ7SensorRepository = iMQ7SensorRepository;

        public async Task<List<MQ7Sensor>> GetMQ7SensorDataAsync()
        {
            return await _iMQ7SensorRepository.GetMQ7SensorDataAsync();
        }
        public async Task<long> CreateMQ7SensorDataAsync(MQ7SensorDto mQ7SensorDto)
        {
            return await _iMQ7SensorRepository.CreateMQ7SensorDataAsync(mQ7SensorDto);
        }
    }
}
  