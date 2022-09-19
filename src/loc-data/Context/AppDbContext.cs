using loc_data.Models;
using Microsoft.EntityFrameworkCore;

namespace loc_data.Context
{
    public class AppDbContext : DbContext 
    {
        public AppDbContext (DbContextOptions<AppDbContext> options): base(options)
        {

        }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Filme> Filme { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Locacao> Locacao { get; set; }

    }
}
