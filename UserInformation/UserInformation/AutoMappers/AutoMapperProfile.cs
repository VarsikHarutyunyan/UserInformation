using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserInfo.Data.Entities;
using UserInfo.Shared;

namespace UserInformation.AutoMappers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<UserCreateModel, User>().ReverseMap();
            CreateMap<UserModel, User>().ReverseMap();
        }
    }
}
