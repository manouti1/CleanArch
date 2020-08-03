namespace CleanArch.Application.AutoMapper
{
    using CleanArch.Application.ViewModels;
    using CleanArch.Domain.Models;
    using global::AutoMapper;

    public class DomainToViewModelProfile : Profile
    {
        public DomainToViewModelProfile()
        {
            CreateMap<Course, CourseViewModel>();
        }
    }
}