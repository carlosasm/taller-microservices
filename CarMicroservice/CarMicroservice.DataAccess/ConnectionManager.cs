using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarMicroservice.DataAccess
{
    public class ConnectionManager
    {
        /*
        private readonly IConfiguration configuration;

        public ConnectionManager(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        
        public IDbConnection CreateConnection(string keyName)
        {
            return new SqlConnection(ConfigurationExtensions.GetConnectionString(configuration, $"{keyName}"));
        }
        */
    }
}
