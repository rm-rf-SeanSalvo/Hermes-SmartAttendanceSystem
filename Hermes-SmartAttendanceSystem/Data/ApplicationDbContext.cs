using Microsoft.EntityFrameworkCore;
using Hermes_SmartAttendanceSystem.Models; // Replace with actual namespace of your models

namespace Hermes_SmartAttendanceSystem.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Perimeter> Perimeters { get; set; }
        public DbSet<PerimeterAssignment> PerimeterAssignments { get; set; }
        public DbSet<Shift> Shifts { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<EmployeeViolation> EmployeeViolations { get; set; }
        public DbSet<RequestApplication> RequestApplications { get; set; }

        public async Task<User?> CheckUserLoginAsync(string username, string password)
        {
            var users = await Users
                .FromSqlRaw("EXEC CheckUserLogin @Username = {0}, @Password = {1}", username, password)
                .AsNoTracking()
                .ToListAsync();

            return users.FirstOrDefault();
        }

    }

}


