using System.Data.Entity;
using Microsoft.EntityFrameworkCore;
using PrivateOfficeDataBaseAPI.Models;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace PrivateOfficeDataBaseAPI.Data
{
    public class PrivateOfficeDataBaseAPIContext : DbContext
    {
        public PrivateOfficeDataBaseAPIContext (DbContextOptions<PrivateOfficeDataBaseAPIContext> options)
            : base(options)
        { }
        /*сущности модели*/
		public Microsoft.EntityFrameworkCore.DbSet<Teacher> Teacher { get; set; }

        public Microsoft.EntityFrameworkCore.DbSet<Course> Course { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Course> Classes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Teacher>()
                .HasOne(course => course.Course)
                .WithOne(teacher => teacher.Teacher)
                .HasForeignKey<Course>(course => course.IdTeacher);
            base.OnModelCreating(modelBuilder);
        }
    }
}
