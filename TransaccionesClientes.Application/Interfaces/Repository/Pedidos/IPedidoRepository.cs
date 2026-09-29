namespace TransaccionesClientes.Application.Interfaces.Repository.Pedidos
{
    public interface IPedidoRepository
    {
        Task<long> CrearPedidoConDescuentoAsync(long idCliente, decimal total);
    }
}
