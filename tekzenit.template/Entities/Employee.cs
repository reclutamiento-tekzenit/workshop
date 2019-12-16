using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tekzenit.template.Entities
{
    public class Employee : BaseEntity
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public int Salary { get; set; }
    }
}
