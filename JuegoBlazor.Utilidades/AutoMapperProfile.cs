using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoMapper;
using JuegoBlazor.DTO;
using JuegoBlazor.Modelo;

namespace JuegoBlazor.Utilidades
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            //complete automapper profile
            CreateMap<User, UserDTO>().ReverseMap();
            
        }
    }
}
