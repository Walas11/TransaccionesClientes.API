using TransaccionesClientes.Application.DTOs.Pedidos;
using TransaccionesClientes.Application.Interfaces.Repository.Clientes;
using TransaccionesClientes.Application.Interfaces.Repository.Pedidos;
using TransaccionesClientes.Application.Interfaces.Services.Pedidos;

namespace TransaccionesClientes.Application.Services.Pedidos
{
    public class PedidosServices : IPedidosServices
    {
        private readonly IPedidoRepository _pedidoRepository;

        public PedidosServices(IPedidoRepository pedidoRepository)
        {
            _pedidoRepository = pedidoRepository;
        }

        public async Task<PedidosResponseDto> CrearPedidoAsync(PedidosRequestDto dto)
        {
            // Validación de negocio ANTES de tocar la BD
            if (dto.Total <= 0)
                throw new ArgumentException("El total debe ser mayor a 0");

            // Llamada al SP (la transacción vive dentro del SP)
            var idPedido = await _pedidoRepository.CrearPedidoConDescuentoAsync(dto.IdCliente, dto.Total);

            return new PedidosResponseDto
            {
                IdPedido = idPedido,
                IdCliente = dto.IdCliente,
                Total = dto.Total,
                Estado = "Pendiente",
                Fecha = DateTime.UtcNow
            };
        }
    }
}
