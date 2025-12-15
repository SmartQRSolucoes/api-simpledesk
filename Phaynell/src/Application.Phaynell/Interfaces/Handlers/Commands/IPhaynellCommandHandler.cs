namespace Application.Phaynell.Interfaces.Handlers.Commands
{
    public interface IPhaynellCommandHandler
    {
        string CreateGetOfQuery(Int64 numero_of);
        string CreateGetOfAcompanhamentoQuery(Int64 numero_of);
        string CreateGetOfsQuery();
        string CreateGetOfsAcompanhamentosQuery();
    }
}
