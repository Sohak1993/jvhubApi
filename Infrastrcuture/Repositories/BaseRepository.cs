
using Core.Interfaces.IRepositories;
using Infrastrcuture.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastrcuture.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly ApplicationDbContext _dbContext;
        protected DbSet<T> DbSet => _dbContext.Set<T>();

        public BaseRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<T> Create(T model)
        {
            throw new NotImplementedException();
        }

        public Task Delete(T model)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<T> Get<Tid>(Tid id)
        {
            throw new NotImplementedException();
        }

        public Task Update(T model)
        {
            throw new NotImplementedException();
        }
    }
}
