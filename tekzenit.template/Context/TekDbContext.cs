using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tekzenit.template.Entities;

namespace tekzenit.template.Context
{
    public class TekDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        public TekDbContext()
        {

        }

        public TekDbContext(DbContextOptions<TekDbContext> options) : base(options)
        {

        }
    }
}
