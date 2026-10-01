using TransaccionesClientes.Application.DTOs.Clientes;
using TransaccionesClientes.Common.GeneralServices.Middleware;

namespace TransaccionesClientes.Application.Interfaces.Services.Clientes
{
    public interface IClientesServices
    {
        Task<Result<List<ClientesResponseDto>>> GetListClientesAsync ();
    }
}
