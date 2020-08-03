namespace CleanArch.Application.Services
{
    using System.Collections.Generic;
    using CleanArch.Application.Interfaces;
    using CleanArch.Application.ViewModels;
    using CleanArch.Domain.Commands;
    using CleanArch.Domain.Core.Bus;
    using CleanArch.Domain.Interfaces;
    using global::AutoMapper;
    using global::AutoMapper.QueryableExtensions;

    public class CourseService : ICourseService
    {
        readonly IMediatorHandler _bus;
        readonly ICourseRepository _courseRepository;
        private IMapper _autoMapper;
        public CourseService(ICourseRepository courseRepository, IMediatorHandler bus, IMapper mapper)
        {
            _courseRepository = courseRepository;
            _bus = bus;
            _autoMapper = mapper;
        }

        public void Create(CourseViewModel courseViewModel) =>
            _bus.SendCommand(_autoMapper.Map<CreateCourseCommand>(courseViewModel));

        public IEnumerable<CourseViewModel> GetCourses() =>
            _courseRepository.GetCourses().ProjectTo<CourseViewModel>(_autoMapper.ConfigurationProvider);
    }
}