using System.Net.Mail;
using System.Threading.Tasks;
using CoralTestTask.Data.Repositories;
using CoralTestTask.Models;
using DIMS_Core.DataAccessLayer.Interfaces;

namespace CoralTestTask.Data.UnitOfWork
{
    class UnitOfWork : IUnitOfWork
    {
        private CoralDbContext _context;

        public UnitOfWork(CoralDbContext context)
        {
            _context = context;
        }

        private UserRepository _userRepository;
        public IRepository<User> UserRepository => _userRepository ??= new UserRepository(_context);
        
        public Task SaveChangesAsync()
        {
            return _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
        public ValueTask DisposeAsync()
        {
            return _context.DisposeAsync();
        }
    }
}