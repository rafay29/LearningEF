using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseFirstEF.EntityLayer
{
    [Table("Employee",Schema ="Chapter2")]
    public abstract class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeID { get; protected set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
