using Atmosync.Api.Interfaces.IRepositories;
using Atmosync.Api.Interfaces.IServices;
using Atmosync.Api.Models.Entities;
using Atmosync.Api.Repository;
using Atmosync.Shared.Models.DtoModels;

namespace Atmosync.Api.Services
{
    public class MQ136SensorService : IMQ136SensorService
    {
        private readonly IMQ136SensorRepository _iMQ136SensorRepository;

        public MQ136SensorService(IMQ136SensorRepository iMQ136SensorRepository) => _iMQ136SensorRepository = iMQ136SensorRepository;

        public async Task<List<MQ136Sensor>> GetMQ136SensorDataAsync()
        {
            return await _iMQ136SensorRepository.GetMQ136SensorDataAsync();
        }
        public async Task<long> CreateMQ136SensorDataAsync(MQ136SensorDto mQ136SensorDto)
        {
            return await _iMQ136SensorRepository.CreateMQ136SensorDataAsync(mQ136SensorDto);
        }

        public async Task<int> DeleteMQ136Async(long mQ136Id)
        {
            if (mQ136Id <= 0)
            {
                throw new ArgumentException("Invalid MQ136 ID.");
            }

            return await _iMQ136SensorRepository.DeleteMQ136SensorDataAsync(mQ136Id);
        }
    }
}
