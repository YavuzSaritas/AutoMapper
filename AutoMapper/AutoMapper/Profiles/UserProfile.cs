using AutoMapper;
using AutoMapper.Entities;
using AutoMapperExample.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMapperExample.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserViewModel>()
                .ForMember(p => p.Name,
                s => s.MapFrom(src => src.FirstName))
                 .ForMember(p => p.Surname,
                s => s.MapFrom(src => src.LastName))
                .ForMember(p=>p.Country,
                s=>s.MapFrom(src => src.Adress.Country))
                .ForMember(p => p.FullAdress,
                s => s.MapFrom(src => src.Adress.GetFullAdress))
                .ReverseMap();
        }
    }
}
