using System;
using System.Collections.Generic;
using System.Text;
using Template_Users_Control.Data.Context;
using Template_Users_Control.Domain.Entities;
using Template_Users_Control.Domain.Interfaces;

namespace Template_Users_Control.Data.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(TemplateContext context)
            : base(context) { }

        public IEnumerable<User> GetAll()
        {
            return Query(x => !x.IsDeleted);
        }
    }
}
