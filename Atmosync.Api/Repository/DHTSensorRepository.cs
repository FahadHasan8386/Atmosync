using System.Data;
using Atmosync.Api.Interfaces.IRepositories;
using Atmosync.Shared.Models.DtoModels;
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

        public async Task<long> CreateDHTSensorDataAsync(DHTSensorDto dHTSensorDto)
        {
            const string sql = @"INSERT INTO DHTSensor (Temperature, Humidity, CreatedBy, CreatedAt, InActive)
                             OUTPUT INSERTED.Id
                             VALUES (@Temperature, @Humidity, @CreatedBy, @CreatedAt, 0);
            ";
            _connection.Open();
            return await _connection.ExecuteScalarAsync<long>(sql, dHTSensorDto);
        }

        public async Task<int> DeleteDHTSensorDataAsync(long dhtId)
        {
            var sql = @"DELETE FROM DHTSensor WHERE Id = @Id";
            _connection.Open();
            var result = await _connection.ExecuteAsync(sql, new
            {
                @Id = dhtId
            });
            _connection.Close();
            return result;
        }

    }
}
