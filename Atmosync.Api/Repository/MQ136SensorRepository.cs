using System.Data;
using Atmosync.Api.Interfaces.IRepositories;
using Atmosync.Api.Models.Entities;
using Atmosync.Shared.Models.DtoModels;
using Dapper;

namespace Atmosync.Api.Repository
{
    public class MQ136SensorRepository : IMQ136SensorRepository
    {
        private readonly IDbConnection _connection;

        public MQ136SensorRepository(IDbConnection connection) => _connection = connection;

        public async Task<List<MQ136Sensor>> GetMQ136SensorDataAsync()
        {
            const string sql = "SELECT * FROM MQ136Sensor";

            _connection.Open();
            var result = await _connection.QueryAsync<MQ136Sensor>(sql);
            _connection.Close();
            return result.ToList();

        }

        public async Task<long> CreateMQ136SensorDataAsync(MQ136SensorDto mQ136SensorDto)
        {
            const string sql = @"INSERT INTO MQ136Sensor (H2SLevel,  CreatedBy, CreatedAt, InActive)
                             OUTPUT INSERTED.Id
                             VALUES (@H2SLevel, @CreatedBy, @CreatedAt, 0);
            ";
            _connection.Open();
            return await _connection.ExecuteScalarAsync<long>(sql, mQ136SensorDto);
        }

        public async Task<int> DeleteMQ136SensorDataAsync(long mQ136Id)
        {
            var sql = @"DELETE FROM MQ136Sensor WHERE Id = @Id";
            _connection.Open();
            var result = await _connection.ExecuteAsync(sql, new
            {
                @Id = mQ136Id
            });
            _connection.Close();
            return result;
        }
    }
}
  