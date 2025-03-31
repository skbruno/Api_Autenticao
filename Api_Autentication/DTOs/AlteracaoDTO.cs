﻿using System.Text.Json.Serialization;

namespace Api_Autentication.DTOs
{
    public class AlteracaoDTO
    {
        [JsonIgnore]
        public int UsuarioId { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
    }
}
