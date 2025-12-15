using Domain.Phaynell.Models;

namespace Application.Phaynell.Interfaces.Services
{
    public interface IPhaynellService
    {
        Task<Of?> GetOf(Int64 numero_of);
        Task<Of_Acompanhamento?> GetOfAcompanhamento(Int64 numero_of);
        Task<string> GetOfs();
        Task<string> GetOfsAcompanhamentos();
    }
}
