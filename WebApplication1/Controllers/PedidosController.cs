using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TransaccionesClientes.Application.Interfaces.Services.Pedidos;

namespace TransClientes.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class PedidosController : ControllerBase
    {
        private readonly IPedidosServices _pedidosServices;
        public PedidosController(IPedidosServices pedidosServices)
        {
            _pedidosServices = pedidosServices;
        }

    }
}
