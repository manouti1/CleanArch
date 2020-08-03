namespace CleanArch.Application.AutoMapper
{
    using CleanArch.Application.ViewModels;
    using CleanArch.Domain.Commands;
    using global::AutoMapper;

    public class ViewModelToDomainProfile : Profile
    {
        public ViewModelToDomainProfile()
        {
            CreateMap<CourseViewModel, CreateCourseCommand>()
                .ConstructUsing(c => new CreateCourseCommand(c.Name, c.Description, c.ImageUrl));
        }
    }
}