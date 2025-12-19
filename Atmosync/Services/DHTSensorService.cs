using Atmosync.Api.Interfaces.IRepositories;
using Atmosync.Api.Interfaces.IServices;
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

    }
}
