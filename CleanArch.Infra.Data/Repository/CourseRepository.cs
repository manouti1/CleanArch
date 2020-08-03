using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Infra.Data.Repository
{
    using System.Linq;
    using CleanArch.Domain.Interfaces;
    using CleanArch.Domain.Models;
    using CleanArch.Infra.Data.Context;

    public class CourseRepository : ICourseRepository
    {
        private UniversityDbContext _ctx;

        public CourseRepository(UniversityDbContext ctx)
        {
            _ctx = ctx;
        }

        public IQueryable<Course> GetCourses() =>
            _ctx.Courses;

        public void Add(Course course)
        {
            _ctx.Courses.Add(course);
            _ctx.SaveChanges();
        }
    }
}
