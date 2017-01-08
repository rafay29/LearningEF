using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseFirstEF.EntityLayer
{
    public class HourlyEmployee : Employee
    {
        public decimal? Wage { get; set; }
    }
}
