using Microsoft.EntityFrameworkCore;
using TransaccionesClientes.Application.Interfaces.Repository.Clientes;
using TransaccionesClientes.Domain.Entityes.Clientes;
using TransaccionesClientes.Infraestructure.Context;

namespace TransaccionesClientes.Infraestructure.Respositories.Clientes
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly AppDbContext _context;

        public ClienteRepository(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }
        public async Task<List<Cliente>> GetListClientes()
        {
            return await _context.Clientes
                .AsNoTracking()
                .ToListAsync();
        }
    }
}
