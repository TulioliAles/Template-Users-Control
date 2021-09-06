using AutoMapper;
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
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public List<UserViewModel> Get()
        {
            List<UserViewModel> userViewModels = new List<UserViewModel>();

            IEnumerable<User> users = _userRepository.GetAll();

            userViewModels = _mapper.Map<List<UserViewModel>>(users);

            return userViewModels;
        }

        public bool Post(UserViewModel userViewModel)
        {
            User _user = _mapper.Map<User>(userViewModel);

            _userRepository.Create(_user);

            return true;
        }

        public UserViewModel GetById(string id)
        {
            if (!Guid.TryParse(id, out Guid userId))
                throw new Exception("UserID inválido");

            User user = _userRepository.Find(x => x.Id == userId && !x.IsDeleted);

            if (user == null)
                throw new Exception("Usuário não encontrado");

            return _mapper.Map<UserViewModel>(user);
        }

        public bool Put(UserViewModel userViewModel)
        {
            User user = _userRepository.Find(x => x.Id == userViewModel.Id && !x.IsDeleted);

            if(user == null)
                throw new Exception("Usuário não encontrado");

            user = _mapper.Map<User>(userViewModel);

            _userRepository.Update(user);

            return true;
        }

        public bool Delete(string id)
        {

        }
    }
}
