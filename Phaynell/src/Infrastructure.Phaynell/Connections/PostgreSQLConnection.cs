using Domain.Phaynell.Interfaces.Connections;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace Infrastructure.Phaynell.Connections
{
    public class PostgreSQLConnection : IPostgreSQLConnection
    {
        private readonly string? _connectionstring;
        private IDbConnection _connection;

        public PostgreSQLConnection(IDbConnection connection) =>
            _connection = connection;

        public PostgreSQLConnection(IConfiguration configuration) =>
            _connectionstring = configuration.GetConnectionString("Connection");

        public void Dispose() => _connection?.Dispose();

        public IDbConnection GetIDbConnection()
        {
            try
            {
                _connection = new Npgsql.NpgsqlConnection(_connectionstring.Replace("[catalog]", "master").Replace("[database]", "master"));
                _connection.Open();
                return _connection;
            }
            catch (Exception ex)
            {
                _connection?.Dispose();
                throw new InvalidOperationException("Failed to establish a database connection.", ex);
            }
        }
    }
}
