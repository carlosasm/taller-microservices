using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerMicroservice.DataAccess.Interface;

namespace TallerMicroservice.DataAccess
{
    public class ConnectionManager : IConnectionManager
    {
        private readonly IConfiguration configuration;

        public ConnectionManager(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public IDbConnection CreateConnection(string keyName)
        {
            return new SqlConnection(ConfigurationExtensions.GetConnectionString(configuration, $"{keyName}"));
        }
    }
}
