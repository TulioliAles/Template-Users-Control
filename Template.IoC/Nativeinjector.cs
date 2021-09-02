using Microsoft.Extensions.DependencyInjection;
using System;
using Template_Users_Control.Application.Interfaces;
using Template_Users_Control.Application.Services;
using Template_Users_Control.Data.Repositories;
using Template_Users_Control.Domain.Interfaces;

namespace Template.IoC
{
    public static class Nativeinjector
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IUserRepository, UserRepository>();
        }
    }
}
