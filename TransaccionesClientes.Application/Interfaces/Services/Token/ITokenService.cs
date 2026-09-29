using TransaccionesClientes.Application.DTOs.Clientes;

namespace TransaccionesClientes.Application.Interfaces.Services.Token
{
    public interface ITokenService
    {
        string GetToken(ClientesResponseDto clienteResponseDto);
    }
}
