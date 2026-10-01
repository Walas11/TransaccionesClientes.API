using Microsoft.Extensions.Logging;
using TransaccionesClientes.Application.DTOs.Clientes;
using TransaccionesClientes.Application.Interfaces.Repository.Clientes;
using TransaccionesClientes.Application.Interfaces.Services.Clientes;
using TransaccionesClientes.Common.GeneralServices.Middleware;

namespace TransaccionesClientes.Application.Services.Clientes
{
    public class ClientesServices : IClientesServices
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly ILogger<ClientesServices> _logger;

        public ClientesServices(IClienteRepository clienteRepository, ILogger<ClientesServices> logger)
        {
            _clienteRepository = clienteRepository;
            _logger = logger;
        }
        public async Task<Result<List<ClientesResponseDto>>> GetListClientesAsync ()
        {
            var Clientes = await _clienteRepository.GetListClientes();

            if (Clientes is null)
                return Result<List<ClientesResponseDto>>.Failure("Cliente no encontrado");

            var result = Clientes.Select(c => new ClientesResponseDto
            {
                IdCliente = c.IdCliente,
                Nombre = c.Nombre ?? "",
                Email = c.Email ?? "",
                Activo = c.Activo,
                TieneDescuento = c.TieneDescuento
            }).ToList();

            return Result<List<ClientesResponseDto>>.Success(result);
        }
    }
}
