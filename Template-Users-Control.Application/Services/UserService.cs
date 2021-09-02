using System;
using System.Collections.Generic;
using System.Text;
using Template_Users_Control.Application.Interfaces;
using Template_Users_Control.Application.ViewModels;
using Template_Users_Control.Domain.Entities;
using Template_Users_Control.Domain.Interfaces;

namespace Template_Users_Control.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public List<UserViewModel> Get()
        {
            List<UserViewModel> userViewModels = new List<UserViewModel>();

            IEnumerable<User> users = _userRepository.GetAll();

            foreach (var item in users)
            {
                userViewModels.Add(new UserViewModel
                {
                    Id = item.Id,
                    Name = item.Name,
                    Email = item.Email
                });
            }

            return userViewModels;
        }
    }
}
