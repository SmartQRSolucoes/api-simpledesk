using Application.Phaynell.Interfaces.Handlers.Commands;

namespace Application.Phaynell.Handlers.Commands
{
    public class PhaynellCommandHandler : IPhaynellCommandHandler
    {
        public string CreateGetOfAcompanhamentoQuery(Int64 numero_of)
        {
            return $@"SELECT * FROM OF_ACOMPANHAMENTO WHERE NUMERO_OF = {numero_of}";
        }

        public string CreateGetOfQuery(Int64 numero_of)
        {
            return $@"SELECT * FROM O_F WHERE NUMERO_OF = {numero_of}";
        }

        public string CreateGetOfsAcompanhamentosQuery()
        {
            //TESTE
            return $@"SELECT TOP 100 * FROM OF_ACOMPANHAMENTO";
        }

        public string CreateGetOfsQuery()
        {
            //TESTE
            return $@"SELECT TOP 100 * FROM O_F";
        }
    }
}
