using DataLayer.Context;
using DataLayer.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly appDbContext _context;
        public IUserRepository UserRepository { get; }
        public UnitOfWork(appDbContext DbContext,
            IUserRepository userRepository)
        {
            this._context = DbContext;
            this.UserRepository = userRepository;

        }

        public int Complete()
        {
            return _context.SaveChanges();
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
        }
    }
}
