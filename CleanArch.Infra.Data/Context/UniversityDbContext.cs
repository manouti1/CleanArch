namespace CleanArch.Infra.Data.Context
{ 
    using CleanArch.Domain.Models;
    using Microsoft.EntityFrameworkCore;

    public class UniversityDbContext : DbContext
    {
        public UniversityDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Course> Courses { get; set; }
    }
}