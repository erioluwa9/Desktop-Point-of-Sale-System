using Point_of_Sale_System.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Point_of_Sale_System
{
    public class PointOfSaleContext : DbContext
    {
        public DbSet<CategoryCl> Category { get; set; }
        public DbSet<CustomerCl> Customer { get; set; }
        public DbSet<ProductCl> Product { get; set; }
        public DbSet<SalesCl> Sales { get; set; }
        public DbSet<SalesList> SaleList { get; set; }
        public DbSet<SalesDetails> SaleDetails { get; set; }

    }
}
