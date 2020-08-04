using AutoMapper;
using InmobiliarioAPI.Dtos;
using InmobiliarioAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InmobiliarioAPI.Profiles
{
    public class PropertiesProfile : Profile
    {
        public PropertiesProfile()
        {
            CreateMap<Property, PropertyReadDto>();
        }
    }
}
