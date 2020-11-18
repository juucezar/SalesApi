using Microsoft.EntityFrameworkCore;

namespace SaleAPI.Models
{
    public class ClientContext : DbContext
    {
        public ClientContext(DbContextOptions<ClientContext> options)
          : base(options)
        {

        }

        public DbSet<Client> Product { get; set; }
    }
}
