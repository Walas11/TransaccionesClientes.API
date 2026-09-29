using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TransaccionesClientes.Application.DTOs.Clientes;
using TransaccionesClientes.Application.Interfaces.Services.Clientes;

namespace TransClientes.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ClientesController : ControllerBase
    {
        private readonly IClientesServices _clientesServices;
        public ClientesController(IClientesServices clientesServices)
        {
            _clientesServices = clientesServices;
        }

        [HttpPost("clientes")]
        public async Task <List<ClientesResponseDto>> GetListClientesAsync() 
        {
            return await _clientesServices.GetListClientesAsync();
        }

    }
}
