using Microsoft.EntityFrameworkCore;

namespace RentalAgencyApi.Models
{
    public class ReservaContext : DbContext
    {
        public ReservaContext(DbContextOptions<ReservaContext> options) : base(options) { }
        public DbSet<Reserva> Reserva { get; set; } = null;
        public DbSet<Veiculo> Veiculo { get; set; } = null;
        public DbSet<Cliente> Cliente { get; set; } = null;
    }
}
