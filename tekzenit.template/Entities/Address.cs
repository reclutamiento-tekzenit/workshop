using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tekzenit.template.Entities
{
    public class Address : BaseEntity
    {
        public string Street { get; set; }
        public string ZipCode { get; set; }
    }
}
