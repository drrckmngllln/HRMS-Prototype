using HRMS.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Infrastructure
{
    internal class StoreContext : DbContext
    {
        public DbSet<AccessLevels> AccessLevels { get; set; }
        public DbSet<AttendanceSetup> AttendanceSetups { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Leave> Leaves { get; set; }
        public DbSet<LeaveSetup> LeaveSetups { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Users> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["constring"].ConnectionString);
        }
    }
}
