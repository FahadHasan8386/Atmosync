using System.Data;
using Atmosync.Api.Interfaces.IRepositories;
using Atmosync.Api.Models.Entities;
using Dapper;

namespace Atmosync.Api.Repository
{
    public class MQ7SensorRepository : IMQ7SensorRepository
    {
        private readonly IDbConnection _connection;

        public MQ7SensorRepository(IDbConnection connection) => _connection = connection;

        public async Task<List<MQ7Sensor>> GetMQ7SensorDataAsync()
        {
            const string sql = "SELECT * FROM MQ7Sensor";

            _connection.Open();
            var deposits = await _connection.QueryAsync<MQ7Sensor>(sql);
            _connection.Close();
            return deposits.ToList();

        }
    }
}
