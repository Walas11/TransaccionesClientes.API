using TransaccionesClientes.Application.DTOs.Pedidos;

namespace TransaccionesClientes.Application.DTOs.Clientes
{
    public class ClientesResponseDto
    {
        public long IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaRegistro { get; set; }
        public bool Activo { get; set; }
        public bool TieneDescuento { get; set; }
        public int TotalPedidos { get; set; }
        public List<PedidosResponseDto>? Pedidos { get; set; }
    }
}
