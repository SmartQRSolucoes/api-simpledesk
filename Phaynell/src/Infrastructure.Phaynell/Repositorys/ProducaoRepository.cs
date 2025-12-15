using Application.Phaynell.Interfaces.Handlers.Commands;
using Domain.Phaynell.Interfaces.Repository;
using Domain.Phaynell.Interfaces.Repositorys;
using Domain.Phaynell.Models;

namespace Infrastructure.Phaynell.Repositorys
{
    public class ProducaoRepository : IProducaoRepository
    {
        private readonly IPhaynellRepository _phaynellRepository;
        private readonly IPhaynellCommandHandler _phaynellCommandHandler;

        public ProducaoRepository(IPhaynellRepository phaynellRepository, IPhaynellCommandHandler phaynellCommandHandler) =>
            (_phaynellRepository, _phaynellCommandHandler) = (phaynellRepository, phaynellCommandHandler);

        public async Task<Of?> GetOf(Int64 numero_of)
        {
            var sql = _phaynellCommandHandler.CreateGetOfQuery(numero_of);
            return await _phaynellRepository.GetRecord<Of>(sql);
        }

        public async Task<Of_Acompanhamento?> GetOfAcompanhamento(Int64 numero_of)
        {
            var sql = _phaynellCommandHandler.CreateGetOfAcompanhamentoQuery(numero_of);
            return await _phaynellRepository.GetRecord<Of_Acompanhamento>(sql);
        }

        public async Task<IEnumerable<Of?>> GetOfs()
        {
            var sql = _phaynellCommandHandler.CreateGetOfsQuery();
            return await _phaynellRepository.GetRecords<Of>(sql);
        }

        public async Task<IEnumerable<Of_Acompanhamento?>> GetOfsAcompanhamentos()
        {
            var sql = _phaynellCommandHandler.CreateGetOfsAcompanhamentosQuery();
            return await _phaynellRepository.GetRecords<Of_Acompanhamento>(sql);
        }
    }
}
