using Microsoft.EntityFrameworkCore;
using StudentRaaCode.Web.Models;

namespace StudentRaaCode.Web.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; } = null!;
    }
}
