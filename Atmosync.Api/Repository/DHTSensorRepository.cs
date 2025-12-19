using System.Data;
using Atmosync.Api.Interfaces.IRepositories;
using Atmosync.Api.Models.Entities;
using Dapper;

namespace Atmosync.Api.Repository
{
    public class DHTSensorRepository : IDHTSensorRepository
    {
        private readonly IDbConnection _connection;

        public DHTSensorRepository(IDbConnection connection) => _connection = connection;

        public async Task<List<DHTSensor>> GetDHTSensorDataAsync()
        {
            const string sql = "SELECT * FROM DHTSensor";
            _connection.Open();
            var data = await _connection.QueryAsync<DHTSensor>(sql);
            _connection.Close();
            return data.ToList();
        }
    }
}
