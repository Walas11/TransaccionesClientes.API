using TransaccionesClientes.Domain.Entityes.Clientes;

namespace TransaccionesClientes.Application.Interfaces.Repository.Clientes
{
    public interface IClienteRepository
    {
        Task<List<Cliente>> GetListClientes();
    }
}
