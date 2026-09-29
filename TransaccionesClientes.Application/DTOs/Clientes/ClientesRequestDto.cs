using System.Numerics;

namespace TransaccionesClientes.Application.DTOs.Clientes
{
    public class ClientesRequestDto
    {
        public long IdCliente { get; set; }
        public string? Nombre { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public long Telefono { get; set; }
        public DateTime FechaRegistro { get; set; }
        public bool Activo { get; set; }
        public bool TieneDescuento { get; set; }
    }
}
