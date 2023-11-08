using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces.IRepositories
{
    public interface IBaseRepository<T> where T : class
    {
        Task<IEnumerable<T>> Get();
        Task<T> Get<Tid>(Tid id);
        Task<T> Create(T model);
        Task Update(T model);
        Task Delete(T model);
    }
}
