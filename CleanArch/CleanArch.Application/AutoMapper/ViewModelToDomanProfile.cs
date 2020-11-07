using AutoMapper;
using CleanArch.Application.ViewModel;
using CleanArch.Domain.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Application.AutoMapper
{
    public class ViewModelToDomanProfile : Profile
    {
        public ViewModelToDomanProfile()
        {
            CreateMap<CourseViewModel, CreateCourseCommand>()
                .ConvertUsing(c => new CreateCourseCommand(c.Name, c.Description, c.ImageUrl));
        }
    }
}
