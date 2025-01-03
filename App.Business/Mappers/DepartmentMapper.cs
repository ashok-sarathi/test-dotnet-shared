using App.Business.Models;
using App.Entity;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Business.Mappers
{
    public class DepartmentMapper : Profile
    {   
        public DepartmentMapper()
        {
            CreateMap<Department, DepartmentModel>().ReverseMap();
        }
    }
}
