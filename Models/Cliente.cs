﻿namespace RentalAgencyApi.Models
{
    public class Cliente
    {
        public long Id { get; set; }
        public string? Nome { get; set; }
        public string? CPF { get; set; }
        public string? Telefone { get; set; }
        public string? Email { get; set; }
        public string? CNH { get; set; }
    }
}
