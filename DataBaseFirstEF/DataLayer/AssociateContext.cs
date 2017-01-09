using DataBaseFirstEF.EntityLayer.Associate;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseFirstEF.DataLayer
{
    public class AssociateContext:DbContext
    {
        public AssociateContext() : base("name=EF6RecipesConn") { }

        public DbSet<Associate> Associates { get; set; }
        public DbSet<AssociateSalary> AssociateSalaries { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Associate>().ToTable("Associate", "Chapter3");
            modelBuilder.Entity<AssociateSalary>().ToTable("AssociateSalary", "Chapter3");

            modelBuilder.Entity<AssociateSalary>().HasKey(x=> x.SalaryId);
        }
    }
}
