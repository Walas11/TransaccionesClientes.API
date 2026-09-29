using System.ComponentModel.DataAnnotations;

namespace TransaccionesClientes.Domain.Entityes.Pedidos
{
    public class Pedido
    {
        [Key]
        public long IdPedido { get; set; }
        public long IdCliente { get; set; }
        public DateTime Fecha { get; set; }
        public double Total { get; set; }
        public string? Estado { get; set; }
    }
}
