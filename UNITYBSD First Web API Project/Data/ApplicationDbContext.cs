using Microsoft.EntityFrameworkCore;
using UNITYBSD_First_Web_API_Project.Models.Entities;

namespace UNITYBSD_First_Web_API_Project.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }

       
    }
}
