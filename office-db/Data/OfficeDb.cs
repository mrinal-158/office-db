using Microsoft.EntityFrameworkCore;
using office_db.Models;

namespace office_db.Data
{
    public class OfficeDb : DbContext
    {
        public OfficeDb(DbContextOptions<OfficeDb> options) : base(options)
        {

        }

        public DbSet<Employee> Employees => Set<Employee>();
    }

}
