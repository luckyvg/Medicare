using Dapper;
using DataLayer.Context;
using DataLayer.IRepository;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly appDbContext _dbContext;
        public UserRepository(appDbContext dbContext)
        {
            _dbContext= dbContext;
        }
      
        public async Task<IEnumerable<Users>> GetAllUsersAsync()
        {
            var query = "SELECT * FROM users";
            var con = _dbContext.CreateConnection();
            var Users = await con.QueryAsync<Users>(query);
            return Users.ToList();
            
        }
    }
}
