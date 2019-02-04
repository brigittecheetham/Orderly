using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Core.Entities;

namespace Infrastructure.Data
{
    public class EfContext : DbContext
    {

        public EfContext() : base("name=Orderly")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Order> OrderHeaders { get; set; }

    }
}
