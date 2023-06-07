using Microsoft.EntityFrameworkCore;
using EmployeesApp.Models;
using Microsoft.Extensions.Options;

namespace EmployeesApp.Models
{
    public class HRDatabaseContext : DbContext
    {
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer(@"Data Source=DESKTOP-8GF8PRF; Initial Catalog=EmployeesDB; Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False");
        }
    }
}
    