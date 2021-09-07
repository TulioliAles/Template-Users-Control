using System;
using System.Collections.Generic;
using System.Text;
using Template_Users_Control.Domain.Entities;

namespace Template_Users_Control.Application.ViewModels
{
    public class UserAuthenticateResponseViewModel
    {
        public UserAuthenticateResponseViewModel(UserViewModel user, string token)
        {
            User = user;
            Token = token;
        }

        public UserViewModel User { get; set; }
        public string Token { get; set; }
    }
}
