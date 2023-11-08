using Core.Entities.General;
using Core.Entities.ViewModels;
using Core.Interfaces.IMapper;
using Core.Interfaces.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public class UserService : IUserService
    {
        private readonly IBaseMapper<User, UserViewModel> _userViewModelMapper;
        private readonly IBaseMapper<UserViewModel, User> _userMapper;


        public UserService(
            IBaseMapper<User, UserViewModel> userViewModelMapper,
            IBaseMapper<UserViewModel, User> userMaper)
        {
            _userViewModelMapper = userViewModelMapper;
            _userMapper = userMaper;
        }

        public Task<UserViewModel> Create()
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<User> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<UserViewModel> Update()
        {
            throw new NotImplementedException();
        }
    }
}
