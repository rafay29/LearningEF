using DataBaseFirstEF.EntityLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseFirstEF.DataLayer
{
    public class StudentContext:DbContext
    {
        public StudentContext() : base("name=EF6RecipesConn") { }

        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Student>().ToTable("Chapter3.Student");
        }
    }
}
