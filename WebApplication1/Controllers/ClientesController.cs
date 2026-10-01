using Microsoft.AspNetCore.Mvc;
using TransaccionesClientes.Application.Interfaces.Services.Clientes;

namespace TransClientes.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class ClientesController : ControllerBase
    {
        private readonly IClientesServices _clientesServices;
        private readonly ILogger<ClientesController> _logger;

        public ClientesController(IClientesServices clientesServices, ILogger<ClientesController> logger)
        {
            _clientesServices = clientesServices;
            _logger = logger;
        }

        [HttpGet("clientes")]
        public async Task<IActionResult> GetListClientesAsync() 
        {
            var result = await _clientesServices.GetListClientesAsync();

            if (!result.IsSuccess)
                return NotFound(new { message = result.Error });

            return Ok(result.Value);
        }
    }
}
