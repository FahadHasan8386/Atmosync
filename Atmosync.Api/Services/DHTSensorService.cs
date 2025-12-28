using Atmosync.Api.Interfaces.IRepositories;
using Atmosync.Api.Interfaces.IServices;
using Atmosync.Shared.Models.DtoModels;
using Atmosync.Api.Models.Entities;

namespace Atmosync.Api.Services
{
    public class DHTSensorService : IDHTSensorService
    {
        private readonly IDHTSensorRepository _iDHTSensorRepository;

        public DHTSensorService(IDHTSensorRepository iDHTSensorRepository) => _iDHTSensorRepository = iDHTSensorRepository;

        public async Task<List<DHTSensor>> GetDHTSensorDataAsync()
        {
            return await _iDHTSensorRepository.GetDHTSensorDataAsync();
        }
        public async Task<long> CreateDHTSensorDataAsync(DHTSensorDto dHTSensorDto)
        {

            if (dHTSensorDto.Temperature > 100 || dHTSensorDto.Temperature < -50)
                throw new Exception("Invalid temperature reading.");

            return await _iDHTSensorRepository.CreateDHTSensorDataAsync(dHTSensorDto);
        }


        public async Task<int> DeleteDHTAsync(long dhtId)
        {
            if (dhtId <= 0)
            {
                throw new ArgumentException("Invalid DHT ID.");
            }

            return await _iDHTSensorRepository.DeleteDHTSensorDataAsync(dhtId);
        }

    }
}
