using AutoMapper;
using HrTasks.Model.Entites;
using HrTasks.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace HrTasks.Services.AutoMapper
{
    public class HrTasksMapper : Profile
    {
        public HrTasksMapper(){

            CreateMap<EmployeeDto, Employee>().ReverseMap();
        }
    }
}
