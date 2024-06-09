using System.ComponentModel.DataAnnotations;

namespace RentalAgencyApi.Models
{
    public class Marca
    {
        [Key]
        public long Id { get; set; }
        public string? Nome { get; set; }
    }
}
