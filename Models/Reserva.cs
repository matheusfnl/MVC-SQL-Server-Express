using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RentalAgencyApi.Models
{
    public class Reserva
    {
        [Key]
        public long? Id { get; set; }
        public long IdVeiculo { get; set; }
        [ForeignKey("IdVeiculo")]
        public long IdCliente { get; set; }
        [ForeignKey("IdCliente")]
        public DateTime? DataInicio { get; set; }
        public DateTime? DataFim { get; set; }
        public double ValorTotal { get; set; }
        public int Status { get; set; }
    }
}
