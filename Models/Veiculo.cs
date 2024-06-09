using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RentalAgencyApi.Models
{
    public class Veiculo
    {
        [Key]
        public long Id { get; set; }
        public long IdMarca { get; set; }
        [ForeignKey("IdMarca")]
        public string? Placa { get; set; }
        public string? Modelo { get; set; }
        public string? Ano { get; set; }
        public string? Cor { get; set; }
        public double? Quilometragem { get; set; }
        public bool? Disponivel { get; set; }
        public double? PrecoDia { get; set; }
    }
}
