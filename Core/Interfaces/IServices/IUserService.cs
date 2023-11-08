using Core.Entities.General;
using Core.Entities.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces.IServices
{
    public interface IUserService
    {
        Task<IEnumerable<User>> Get();
        Task<User> Get(int id);
        Task<UserViewModel> Create();
        Task<UserViewModel> Update();
        Task Delete(int id);
    }
}
