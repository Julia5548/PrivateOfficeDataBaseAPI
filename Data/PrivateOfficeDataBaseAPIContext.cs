using Microsoft.EntityFrameworkCore;
using PrivateOfficeDataBaseAPI.Models;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace PrivateOfficeDataBaseAPI.Data
{
    public class PrivateOfficeDataBaseAPIContext : DbContext
    {
        public PrivateOfficeDataBaseAPIContext (DbContextOptions<PrivateOfficeDataBaseAPIContext> options)
            : base(options)
        {
        }
        /*сущности модели*/
		public DbSet<Teacher> Teacher { get; set; }

        public DbSet<Course> Course { get; set; }

	}
}
