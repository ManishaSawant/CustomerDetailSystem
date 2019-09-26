using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerDetailSystem.Model;
using Microsoft.EntityFrameworkCore;

namespace CustomerDetailSystem.Model
{
    public class CustomerDetailContext:DbContext
    {
        public CustomerDetailContext(DbContextOptions<CustomerDetailContext> options ):base(options)
        {
                
        }
        public DbSet<CustomerDetail> CustomerDetails { get; set; }
    }
}
