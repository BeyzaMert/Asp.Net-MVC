using Microsoft.EntityFrameworkCore;

namespace BlogApiDemo.DataAccessLayer
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-T41TQPB;database=CoreBlogApiDb; integrated security=true;");
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
