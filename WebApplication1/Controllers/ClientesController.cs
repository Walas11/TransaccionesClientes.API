using Microsoft.AspNetCore.Mvc;
using TransaccionesClientes.Application.Interfaces.Services.Clientes;
using Serilog;
using TransaccionesClientes.Application.DTOs.Clientes;

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
            Log.Logger = new LoggerConfiguration().WriteTo
                            .Console()
                            .WriteTo.File("log-.txt", rollingInterval: RollingInterval.Day)
                            .CreateLogger();

            var result = await _clientesServices.GetListClientesAsync();

            if (!result.IsSuccess)
            {
                _logger.LogError("No se pudo obtener los clientes: {result.Error}", result.Error);
                return NotFound(new { message = result.Error });
            }

            return Ok(result.Value);
        }
    }
}
