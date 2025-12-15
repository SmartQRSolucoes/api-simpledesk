using Dapper;
using Domain.Phaynell.Interfaces.Connections;
using Domain.Phaynell.Interfaces.Repository;

namespace Infrastructure.Phaynell.Repository
{
    public class PhaynellRepository : IPhaynellRepository
    {
        private readonly IPostgreSQLConnection _postgreSQLConnection;

        public PhaynellRepository(IPostgreSQLConnection postgreSQLConnection) =>
            (_postgreSQLConnection) = (postgreSQLConnection);

        public async Task<TEntity?> GetRecord<TEntity>(string? sql)
        {
            try
            {
                using (var conn = _postgreSQLConnection.GetIDbConnection())
                {
                    return await conn.QueryFirstOrDefaultAsync<TEntity?>(sql: sql, commandTimeout: 360);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(
                    message: $"Error when trying to get record from database - {ex.Message}"
                );
            }
        }

        public async Task<IEnumerable<TEntity?>> GetRecords<TEntity>(string? sql)
        {
            try
            {
                using (var conn = _postgreSQLConnection.GetIDbConnection())
                {
                    var result = await conn.QueryAsync<TEntity>(sql: sql, commandTimeout: 360);
                    return result.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(
                    message: $"Error when trying to get record from database - {ex.Message}"
                );
            }
        }
    }
}
