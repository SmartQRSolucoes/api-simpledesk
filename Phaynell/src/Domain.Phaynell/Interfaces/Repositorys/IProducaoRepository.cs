using Domain.Phaynell.Models;

namespace Domain.Phaynell.Interfaces.Repositorys
{
    public interface IProducaoRepository
    {
        public Task<Of?> GetOf(Int64 numero_of);
        public Task<Of_Acompanhamento?> GetOfAcompanhamento(Int64 numero_of);
        public Task<IEnumerable<Of?>> GetOfs();
        public Task<IEnumerable<Of_Acompanhamento?>> GetOfsAcompanhamentos();

    }
}
