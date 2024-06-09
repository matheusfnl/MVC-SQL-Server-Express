using Microsoft.EntityFrameworkCore;

namespace RentalAgencyApi.Models
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }
        public DbSet<Cliente> Cliente { get; set; } = null;
        public DbSet<Marca> Marca { get; set; } = null;
        public DbSet<Reserva> Reserva { get; set; } = null;
        public DbSet<Veiculo> Veiculo { get; set; } = null;
    }
}
