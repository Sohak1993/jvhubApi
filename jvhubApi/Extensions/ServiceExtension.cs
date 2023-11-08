using AutoMapper;
using Core.Entities.General;
using Core.Entities.ViewModels;
using Core.Interfaces.IMapper;
using Core.Interfaces.IServices;
using Core.Mapper;
using Core.Services;
using System.Runtime.CompilerServices;

namespace jvhubApi.Extensions
{
    public static class ServiceExtension

    {
        public static IServiceCollection RegisterService(this IServiceCollection services)
        {
            #region Services
            services.AddScoped<IUserService, UserService>();
            #endregion

            #region Repositories

            #endregion

            #region Mapper
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<User, UserViewModel>();
                cfg.CreateMap<UserViewModel, User>();
            });

            IMapper mapper = config.CreateMapper();

            services.AddSingleton<IBaseMapper<User, UserViewModel>>(new BaseMapper<User, UserViewModel>(mapper));
            services.AddSingleton<IBaseMapper<UserViewModel, User>>(new BaseMapper<UserViewModel, User>(mapper));

            #endregion

            return services;
        }
    }
}

