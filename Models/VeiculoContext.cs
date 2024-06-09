using Microsoft.EntityFrameworkCore;

namespace RentalAgencyApi.Models
{
    public class VeiculoContext : DbContext
    {
        public VeiculoContext(DbContextOptions<VeiculoContext> options) : base(options) { }
        public DbSet<Veiculo> Veiculo { get; set; } = null;
        public DbSet<Marca> Marca { get; set; } = null;
    }
}
