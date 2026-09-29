using Microsoft.EntityFrameworkCore;
using TransaccionesClientes.Domain.Entityes.Clientes;
using TransaccionesClientes.Domain.Entityes.Pedidos;

namespace TransaccionesClientes.Infraestructure.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }


        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){ }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().HasKey(c => c.IdCliente);

            modelBuilder.Entity<Pedido>().HasKey(c => c.IdPedido);
        }
    }
}
