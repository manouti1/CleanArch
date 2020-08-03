using System.Collections.Generic;

namespace CleanArch.Application.Interfaces
{
    using CleanArch.Application.ViewModels;

    public interface ICourseService
    {
        IEnumerable<CourseViewModel> GetCourses();
        void Create(CourseViewModel courseViewModel);
    }
}