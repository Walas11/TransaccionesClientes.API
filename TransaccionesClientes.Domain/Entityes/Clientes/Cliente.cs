using System.ComponentModel.DataAnnotations;

namespace TransaccionesClientes.Domain.Entityes.Clientes
{
    public class Cliente
    {
        [Key]
        public long IdCliente { get; set; }
        public string? Nombre { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public long Telefono { get; set; }
        public DateTime FechaRegistro { get; set; }
        public bool Activo { get; set; }
        public bool TieneDescuento { get; set; }
    }
}
