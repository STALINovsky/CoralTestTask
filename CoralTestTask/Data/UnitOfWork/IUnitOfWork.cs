using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoralTestTask.Data.Repositories;
using CoralTestTask.Models;
using DIMS_Core.DataAccessLayer.Interfaces;

namespace CoralTestTask.Data.UnitOfWork
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        public IRepository<User> UserRepository { get; }

        Task SaveChangesAsync();
    }
}
