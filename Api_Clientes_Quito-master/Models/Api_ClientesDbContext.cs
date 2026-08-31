using Microsoft.EntityFrameworkCore;

namespace Api_Clientes.Models
{
    public class Api_ClientesDbContext: DbContext
    {
        public Api_ClientesDbContext(DbContextOptions op):base(op)
        {
            
        }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Servicio> Servicios { get; set; }
    }
}
