using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesAPI.Models
{
    public class ProductContext: DbContext
    {
        public ProductContext(DbContextOptions<Product> dbContextOptions) : base(dbContextOptions)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
