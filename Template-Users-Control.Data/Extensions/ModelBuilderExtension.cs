using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Template_Users_Control.Domain.Entities;

namespace Template_Users_Control.Data.Extensions
{
    public static class ModelBuilderExtension
    {
        public static ModelBuilder SeedData(this ModelBuilder builder)
        {
            builder.Entity<User>()
                .HasData(
                    new User
                    {
                        Id = Guid.Parse("67a4e611-061e-40b5-9670-5539e5695ab5"),
                        Name = "User Default",
                        Email = "userdefault@template.com",
                        DateCreated = new DateTime(2021,08,26),
                        IsDeleted = false,
                        DateUpdated = null
                    }
            );

            return builder;
        } 
    }
}
