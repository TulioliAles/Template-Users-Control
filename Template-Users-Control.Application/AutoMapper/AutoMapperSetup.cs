using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using Template_Users_Control.Application.ViewModels;
using Template_Users_Control.Domain.Entities;

namespace Template_Users_Control.Application.AutoMapper
{
    public class AutoMapperSetup : Profile
    {
        public AutoMapperSetup()
        {
            #region ViewModelToDomain
            CreateMap<UserViewModel, User>();
            #endregion

            #region DomainToViewmodel
            CreateMap<User, UserViewModel>();
            #endregion
        }
    }
}
