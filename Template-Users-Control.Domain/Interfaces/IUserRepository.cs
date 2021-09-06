using System;
using System.Collections.Generic;
using System.Text;
using Template_Users_Control.Domain.Entities;

namespace Template_Users_Control.Domain.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        IEnumerable<User> GetAll();
    }
}
