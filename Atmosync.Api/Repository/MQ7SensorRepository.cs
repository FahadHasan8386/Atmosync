using System.Data;
using Atmosync.Api.Interfaces.IRepositories;
using Atmosync.Shared.Models.DtoModels;
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
            var result = await _connection.QueryAsync<MQ7Sensor>(sql);
            _connection.Close();
            return result.ToList();

        }
        public async Task<long> CreateMQ7SensorDataAsync(MQ7SensorDto mQ7SensorDto)
        {  
            const string sql = @"INSERT INTO MQ7Sensor (COLevel,  CreatedBy, CreatedAt, InActive)
                             OUTPUT INSERTED.Id
                             VALUES (@COLevel, @CreatedBy, @CreatedAt, 0);
            ";
            _connection.Open();
            return await _connection.ExecuteScalarAsync<long>(sql, mQ7SensorDto);
        }
    }
}
