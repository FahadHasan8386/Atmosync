using Atmosync.Api.Interfaces.IRepositories;
using Atmosync.Api.Interfaces.IServices;
using Atmosync.Api.Models.Entities;

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
    }
}
