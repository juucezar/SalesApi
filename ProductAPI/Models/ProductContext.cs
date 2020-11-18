using Microsoft.EntityFrameworkCore;

namespace SaleAPI.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options)
            : base(options)
        {

        }

        public DbSet<Product> Product { get; set; }
    }
}
