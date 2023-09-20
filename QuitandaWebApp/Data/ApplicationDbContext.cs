using Microsoft.EntityFrameworkCore;
using QuitandaWebApp.Models;

namespace QuitandaWebApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Produto> Produto { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
    }
}
