using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace yanovych_back.Models
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Student, StudentView>().ReverseMap();
            CreateMap<Lab, LabView>().ReverseMap();
        }
    }
}
