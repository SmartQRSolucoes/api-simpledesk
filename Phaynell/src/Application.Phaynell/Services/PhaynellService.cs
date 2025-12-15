using Application.Phaynell.Interfaces.Services;
using Domain.Phaynell.Interfaces.Repositorys;
using Domain.Phaynell.Models;
using Newtonsoft.Json;

namespace Application.Phaynell.Services
{
    public class PhaynellService : IPhaynellService
    {
        private readonly IProducaoRepository _producaoRepository;

        public PhaynellService(IProducaoRepository producaoRepository)
        {
            _producaoRepository = producaoRepository;
        }

        public async Task<Of?> GetOf(Int64 numero_of)
        {
            return await _producaoRepository.GetOf(numero_of);
        }

        public async Task<Of_Acompanhamento?> GetOfAcompanhamento(Int64 numero_of)
        {
            return await _producaoRepository.GetOfAcompanhamento(numero_of);
        }

        public async Task<string> GetOfs()
        {
            var Ofs = await _producaoRepository.GetOfs();
            return JsonConvert.SerializeObject(Ofs);
        }

        public async Task<string> GetOfsAcompanhamentos()
        {
            var OfsAcompanhamentos = _producaoRepository.GetOfsAcompanhamentos();
            return JsonConvert.SerializeObject(OfsAcompanhamentos);
        }
    }
}
