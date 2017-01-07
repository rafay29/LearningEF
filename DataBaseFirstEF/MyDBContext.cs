using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseFirstEF
{
    public class PictureContext : DbContext
    {

        public PictureContext() : base("name=PictureContectConn") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<PictureCategory>().HasMany(cat => cat.Subcategories).WithOptional(cat => cat.ParentCategory);
            //modelBuilder.Entity<PictureCategory>().ToTable("PictureCategory","Chapter2").HasMany(cat => cat.Subcategories).WithOptional(cat => cat.ParentCategory);
        }

        public DbSet<PictureCategory> PictureCategories { get; set; }
    }

    public class PictureCategory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryId { get; private set; }
        public string Name { get; set; }
        public int? ParentCategoryId { get; private set; }

        [ForeignKey("ParentCategoryId")]
        public PictureCategory ParentCategory { get; set; }

        public List<PictureCategory> Subcategories { get; set; }

        public PictureCategory()
        {
            Subcategories = new List<PictureCategory>();
        }
    }
}
