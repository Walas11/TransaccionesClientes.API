using TransaccionesClientes.Application.DTOs.Pedidos;

namespace TransaccionesClientes.Application.Interfaces.Services.Pedidos
{
    public interface IPedidosServices
    {
        Task<PedidosResponseDto> CrearPedidoAsync(PedidosRequestDto dto);
    }
}
