using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Domain.Models;
using CleanArchitecture.Infrastructure.Data.Context;
using System;
using System.Collections.Generic;

namespace CleanArchitecture.Infrastructure.Data.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private readonly UniversityDbContext context;

        public CourseRepository(UniversityDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<Course> GetCourses()
        {
            return context.Courses;
        }
    }
}
