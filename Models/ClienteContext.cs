using Microsoft.EntityFrameworkCore;

namespace RentalAgencyApi.Models
{
    public class ClienteContext : DbContext
    {
        public ClienteContext(DbContextOptions<ClienteContext> options) : base(options) { }
        public DbSet<Cliente> Cliente { get; set; } = null;
    }
}
