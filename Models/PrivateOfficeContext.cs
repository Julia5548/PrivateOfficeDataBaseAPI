using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace PrivateOfficeDataBaseAPI.Models
{
    public class PrivateOfficeContext : DbContext

    {
        /*имя бд*/
        public PrivateOfficeContext() : base(@"Server=(localdb)\mssqllocaldb;Database=PrivateOffice;Integrated Security=True") { }
        /*сущности модели*/
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Course> Courses { get; set; }

        /*защиита имен таблиц от плюрализации*/
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
