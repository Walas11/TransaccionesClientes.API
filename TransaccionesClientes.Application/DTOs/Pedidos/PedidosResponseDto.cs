using System.Numerics;

namespace TransaccionesClientes.Application.DTOs.Pedidos
{
    public class PedidosResponseDto
    {
        public long IdPedido { get; set; }
        public long IdCliente { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }
        public string? Estado { get; set; }
    }
}
