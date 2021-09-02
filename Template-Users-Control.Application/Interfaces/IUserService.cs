using System;
using System.Collections.Generic;
using System.Text;
using Template_Users_Control.Application.ViewModels;

namespace Template_Users_Control.Application.Interfaces
{
    public interface IUserService
    {
        List<UserViewModel> Get();
    }
}
