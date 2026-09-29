using TransaccionesClientes.Application.DTOs.Clientes;
using TransaccionesClientes.Application.Interfaces.Repository.Clientes;
using TransaccionesClientes.Application.Interfaces.Services.Clientes;

namespace TransaccionesClientes.Application.Services.Clientes
{
    public class ClientesServices : IClientesServices
    {
        private readonly IClienteRepository _clienteRepository;

        public ClientesServices(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }
        public async Task<List<ClientesResponseDto>> GetListClientesAsync ()
        {
            var Clientes = await _clienteRepository.GetListClientes();

            return Clientes.Select(c => new ClientesResponseDto
            {
                IdCliente = c.IdCliente,
                Nombre = c.Nombre ?? "",
                Email = c.Email ?? "",
                Activo = c.Activo,
                TieneDescuento = c.TieneDescuento
            }).ToList();
        }
    }
}
