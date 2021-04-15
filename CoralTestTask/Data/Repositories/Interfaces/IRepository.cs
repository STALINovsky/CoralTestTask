﻿using System.Linq;
using System.Threading.Tasks;
using CoralTestTask.Models;

namespace DIMS_Core.DataAccessLayer.Interfaces
{
    public interface IRepository<TEntity> where TEntity : IEntity
    {
        IQueryable<TEntity> GetAll();

        Task<TEntity> GetById(int id);

        Task<TEntity> Create(TEntity entity);

        TEntity Update(TEntity entity);

        Task Delete(int id);
    }
}