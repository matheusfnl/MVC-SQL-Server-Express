namespace RentalAgencyApi.Models
{
    public class Reserva
    {
        public long? Id { get; set; }
        public DateTime? DataInicio { get; set; }
        public DateTime? DataFim { get; set; }
        public double ValorTotal { get; set; }
        public int Status { get; set; }
    }
}
