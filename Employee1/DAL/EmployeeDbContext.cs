using Employee1.Models.DBEntities;
using Microsoft.EntityFrameworkCore;

namespace Employee1.DAL
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Employee> Empoyees { get; set; }
    }
}
