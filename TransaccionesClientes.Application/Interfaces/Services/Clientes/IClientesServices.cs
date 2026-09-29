using TransaccionesClientes.Application.DTOs.Clientes;

namespace TransaccionesClientes.Application.Interfaces.Services.Clientes
{
    public interface IClientesServices
    {
        Task<List<ClientesResponseDto>> GetListClientesAsync ();
    }
}
