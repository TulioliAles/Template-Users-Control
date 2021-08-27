using System;
using System.Collections.Generic;
using System.Text;
using Template_Users_Control.Domain.Models;

namespace Template_Users_Control.Domain.Entities
{
    public class User : Entity
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
