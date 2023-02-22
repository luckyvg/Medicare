using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Options;
using System.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Context
{
    public class appDbContext:DbContext
    {
        private IConfiguration _configuration;
        public appDbContext(IConfiguration configuration)
        {
            _configuration= configuration;
        }
        public IDbConnection CreateConnection() => new SqlConnection(_configuration.GetConnectionString("DbConn"));
    }
}
