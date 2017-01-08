using DataBaseFirstEF.EntityLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseFirstEF.DataLayer
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext() : base("name=EF6RecipesConn")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Employee>().Map<FullTimeEmployee>(m => m.Requires("EmployeeType").HasValue(1))
                                           .Map<HourlyEmployee>(m => m.Requires("EmployeeType").HasValue(2));
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
