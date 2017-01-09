﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseFirstEF.EntityLayer.Associate
{
    public class Associate
    {
        public Associate()
        {
            AssociateSalaries = new HashSet<AssociateSalary>();
        }

        public int AssociateId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<AssociateSalary> AssociateSalaries { get; set; }
    }
}
