namespace Api_Autentication.DTOs
{
    public class UsuarioResponseTokenDTO
    {
        public int UsuarioId { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string? Token { get; set; }
    }
}
