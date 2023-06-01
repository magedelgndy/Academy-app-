using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using MVCDay2.Models;

namespace MVCDay2.Models
{
    public class ITIEntity : DbContext
    {
                public ITIEntity()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=MVCDay2;Integrated Security=True;Encrypt=False");
            base.OnConfiguring(optionsBuilder);
        }


        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CrsResult> CourseResults { get; set; }
        public DbSet<Trainee> Trainees  { get; set; }

    }
}
