using Microsoft.EntityFrameworkCore;
using PrivateOfficeDataBaseAPI.Models;

namespace PrivateOfficeDataBaseAPI.Data
{
    public class PrivateOfficeDataBaseAPIContext : DbContext
    {
        public PrivateOfficeDataBaseAPIContext (DbContextOptions<PrivateOfficeDataBaseAPIContext> options)
            : base(options)
        {
        }

        public DbSet<Teacher> Teacher { get; set; }

        public DbSet<Course> Course { get; set; }
    }
}
