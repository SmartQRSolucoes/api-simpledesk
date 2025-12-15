using Domain.Phaynell.Models;

namespace Domain.Phaynell.Interfaces.Repository
{
    public interface IPhaynellRepository
    {
        public Task<TEntity?> GetRecord<TEntity>(string? sql);
        public Task<IEnumerable<TEntity?>> GetRecords<TEntity>(string? sql);
    }
}
