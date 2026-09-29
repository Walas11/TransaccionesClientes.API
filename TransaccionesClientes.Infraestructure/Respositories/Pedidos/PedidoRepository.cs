using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;
using TransaccionesClientes.Application.Interfaces.Repository.Pedidos;
using TransaccionesClientes.Infraestructure.Context;

namespace TransaccionesClientes.Infraestructure.Respositories.Pedidos
{
    public class PedidoRepository : IPedidoRepository
    {
        private readonly AppDbContext _context;
        private readonly string _connectionString;

        public PedidoRepository(AppDbContext appDbContext, IConfiguration configuration)
        {
            _context = appDbContext;
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public async Task<long> CrearPedidoConDescuentoAsync(long idCliente, decimal total)
        {
            await using var connection = new SqlConnection(_connectionString);
            await connection.OpenAsync();

            await using var command = new SqlCommand("sp_CrearPedidoConDescuento", connection)
            {
                CommandType = CommandType.StoredProcedure,
                CommandTimeout = 30
            };

            command.Parameters.Add(new SqlParameter("@IdCliente", SqlDbType.BigInt) { Value = idCliente });
            command.Parameters.Add(new SqlParameter("@Total", SqlDbType.Decimal)
            {
                Value = total,
                Precision = 18,
                Scale = 2
            });

            // El SP devuelve una fila con IdPedido
            var result = await command.ExecuteScalarAsync();

            if (result == null || result == DBNull.Value)
                throw new InvalidOperationException("El SP no devolvió un IdPedido válido");

            return Convert.ToInt64(result);
        }

    }
}
