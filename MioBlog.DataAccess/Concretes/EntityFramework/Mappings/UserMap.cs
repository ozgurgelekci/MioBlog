﻿using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MioBlog.Entities.Concretes;

namespace MioBlog.DataAccess.Concretes.EntityFramework.Mappings
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            ToTable(@"Users", @"dbo");
            HasKey(u => u.UserId);

            Property(u => u.UserId).HasColumnName("UserId");
            Property(u => u.UserName).HasColumnName("UserName");
            Property(u => u.Password).HasColumnName("Password");
            Property(u => u.FirstName).HasColumnName("FirstName");
            Property(u => u.LastName).HasColumnName("LastName");
            Property(u => u.Email).HasColumnName("Email");
        }
    }
}
