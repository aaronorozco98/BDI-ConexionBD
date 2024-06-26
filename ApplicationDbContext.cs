using ConexionEF.Entities;
using Microsoft.EntityFrameworkCore;

namespace ConexionEF
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<TipoProducto> TiposProductos { get; set; }

        public DbSet<MarcaProducto> MarcasProductos { get; set; }

    }
}