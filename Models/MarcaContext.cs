using Microsoft.EntityFrameworkCore;

namespace RentalAgencyApi.Models
{
    public class MarcaContext : DbContext
    {
        public MarcaContext(DbContextOptions<MarcaContext> options) : base(options) { }
        public DbSet<Marca> Marca { get; set; } = null;
    }
}
