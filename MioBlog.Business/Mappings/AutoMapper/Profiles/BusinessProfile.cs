using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MioBlog.Entities.Concretes;

namespace MioBlog.Business.Mappings.AutoMapper.Profiles
{
   public class BusinessProfile:Profile
    {
        public BusinessProfile()
        {
            CreateMap<Post, Post>();
        }
    }
}
