using System.Data;

namespace Domain.Phaynell.Interfaces.Connections
{
    public interface IPostgreSQLConnection
    {
        public IDbConnection GetIDbConnection();
    }
}
