namespace RentalAgencyApi.Models
{
    public class Veiculo
    {
        public long Id { get; set; }
        public string? Placa { get; set; }
        public string? Modelo { get; set; }
        public string? Ano { get; set; }
        public string? Cor { get; set; }
        public double? Quilometragem { get; set; }
        public bool? Disponivel { get; set; }
        public double? PrecoDia { get; set; }
    }
}
