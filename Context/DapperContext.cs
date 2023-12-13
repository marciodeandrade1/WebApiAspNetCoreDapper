using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace WebApiAspNetCoreDapper.Context
{
    public class DapperContext : Dapp
    {
        private readonly string _connectionString;

        public DapperContext(IConfiguration configuration, string connectionStringName)
        {
            _connectionString = configuration.GetConnectionString(connectionStringName);
        }

        public IDbConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }

        // Outros métodos para interagir com o banco usando Dapper
    }
}
