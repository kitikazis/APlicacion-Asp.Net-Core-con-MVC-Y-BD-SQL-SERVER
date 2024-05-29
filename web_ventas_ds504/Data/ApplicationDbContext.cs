using Microsoft.EntityFrameworkCore;
using web_ventas_ds504.Models;

namespace web_ventas_ds504.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
        }

        public DbSet<Personal> Personal { get; set; }
        public DbSet<Venta> Venta { get; set; }
        public DbSet<Marca> Marca { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Producto> Producto { get; set; }
    }
}
